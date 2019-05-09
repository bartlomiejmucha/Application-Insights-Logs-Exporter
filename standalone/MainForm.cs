using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace AILogsExporter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void exportButton_Click(object sender, EventArgs e)
        {
            try
            {
                exportButton.Enabled = false;

                using (var client = new HttpClient())
                {
                    var applicationId = applicationIdTextBox.Text;
                    var apiKey = apiKeyTextBox.Text;
                    var logFilePath = logFilePathTextBox.Text;

                    client.DefaultRequestHeaders.Add("x-api-key", apiKey);
                    client.Timeout = TimeSpan.FromMinutes(10);

                    if (File.Exists(logFilePath))
                    {
                        File.Delete(logFilePath);
                    }

                    HttpResponseMessage response;
                    List<string> lines = null;
                    string lastTimeStamp = null;
                    var batchNumber = 1;
                    do
                    {
                        var query = queryTextBox.Text;
                        if (!string.IsNullOrEmpty(lastTimeStamp))
                        {
                            query += $"\r\n|where timestamp >= datetime({lastTimeStamp})";
                        }

                        query += $"\r\n| top {queryTopNumericBox.Value} by timestamp asc|\r\nproject timestamp, line";
                        query = Uri.EscapeDataString(query);

                        SetStatusLine($"Requesting a log batch #{batchNumber}");

                        response = GetAsyncWithRetry(client, $"https://api.applicationinsights.io/v1/apps/{applicationId}/query?query={query}", 3);
                        if (response.IsSuccessStatusCode)
                        {
                            var responseContent = await response.Content.ReadAsAsync<JObject>();
                            if (responseContent["error"] != null)
                            {
                                MessageBox.Show(responseContent["error"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }

                            lines = responseContent["tables"][0]["rows"].Select(row => row[1].Value<string>()).ToList();
                            if (lines.Any())
                            {
                                if (insertBatchNumberLineCheckBox.Checked)
                                {
                                    File.AppendAllText(logFilePath, $"-- BATCH {batchNumber}\n");
                                }

                                File.AppendAllLines(logFilePath, lines);

                                lastTimeStamp = responseContent["tables"][0]["rows"].Last()[0].Value<DateTime>().ToUniversalTime().ToString("O");
                            }
                        }
                        else
                        {
                            if (response.Content != null)
                            {
                                var responseContent = await response.Content.ReadAsAsync<JObject>();
                                if (responseContent["error"] != null)
                                {
                                    MessageBox.Show(responseContent["error"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                }
                            }

                            MessageBox.Show(response.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }

                        batchNumber++;
                    }
                    while (exportAllBatchesCheckBox.Checked && response.IsSuccessStatusCode && lines.Count >= queryTopNumericBox.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                exportButton.Enabled = true;
                SetStatusLine("");
            }
        }

        private void SetStatusLine(string status)
        {
            statusLineLabel.Text = status;
        }

        private HttpResponseMessage GetAsyncWithRetry(HttpClient client, string requestUri, int retryCount)
        {
            HttpResponseMessage response = null;
            for (var i = 0; i < retryCount; i++)
            {
                response = client.GetAsync(requestUri).Result;
                if (response.IsSuccessStatusCode)
                {
                    return response;
                }

                SetStatusLine($"Retrying #{i+1}");
            }

            return response;
        }
    }
}
