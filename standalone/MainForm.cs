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
                    var startTimestamp = startDateTimePicker.Value.ToUniversalTime().ToString("O");
                    var endTimestamp = endDateTimePicker.Value.ToUniversalTime().ToString("O");
                    var logFilePath = logFilePathTextBox.Text;

                    client.DefaultRequestHeaders.Add("x-api-key", apiKey);
                    client.Timeout = TimeSpan.FromMinutes(10);

                    if (File.Exists(logFilePath))
                    {
                        File.Delete(logFilePath);
                    }

                    HttpResponseMessage response;
                    List<string> lines = null;

                    do
                    {
                        var path = $"http://api.applicationinsights.io/v1/apps/{applicationId}/query?query=traces|where timestamp >= datetime({startTimestamp}) and timestamp <= datetime({endTimestamp})|project timestamp, message|order by timestamp asc";

                        response = await client.GetAsync(path);
                        if (response.IsSuccessStatusCode)
                        {
                            var resultObject = await response.Content.ReadAsAsync<JObject>();
                            lines = resultObject["tables"][0]["rows"].Select(row => row[0].Value<DateTime>().ToString("s") + "|" + row[1].Value<string>()).ToList();
                            if (lines.Any())
                            {
                                File.AppendAllLines(logFilePath, lines);

                                var lastTimeStamp = resultObject["tables"][0]["rows"].Last()[0].Value<DateTime>();

                                startTimestamp = lastTimeStamp.ToUniversalTime().ToString("O");
                            }
                        }
                        else
                        {
                            MessageBox.Show(response.StatusCode.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } while (response.IsSuccessStatusCode && lines != null && lines.Count >= 500000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                exportButton.Enabled = true;
            }
        }
    }
}
