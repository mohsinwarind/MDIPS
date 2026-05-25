using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MDIPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var countries = CultureInfo
                .GetCultures(CultureTypes.SpecificCultures)
                .Select(c =>
                {
                    try
                    {
                        return new RegionInfo(c.Name).EnglishName;
                    }
                    catch
                    {
                        return null;
                    }
                })
                .Where(name => !string.IsNullOrEmpty(name))
                .Distinct()
                .OrderBy(name => name)
                .ToList();

            cbCountry.DataSource = countries;
            cbCountry.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbCountry.AutoCompleteSource = AutoCompleteSource.ListItems;

            progressBar.Visible = false;
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.MarqueeAnimationSpeed = 30;

            lblStatus.Visible = false;
            lblStatus.Text = "Connecting to prediction model...";
            lblStatus.ForeColor = Color.SteelBlue;
        }

        public class DisasterRequest
        {
            public string country { get; set; }
            public string event_type { get; set; }
            public string season { get; set; }
            public int month { get; set; }
            public decimal severity { get; set; }
            public decimal duration_days { get; set; }
            public decimal affected_population { get; set; }
            public decimal deaths { get; set; }
            public decimal injuries { get; set; }
            public decimal infrastructure_damage_score { get; set; }
            public decimal response_time_hours { get; set; }
            public decimal international_aid_million_usd { get; set; }
            public decimal aid_percentage { get; set; }
            public decimal casualty_rate { get; set; }
            public decimal impact_per_capita { get; set; }
            public decimal latitude { get; set; }
            public decimal longitude { get; set; }
        }

        private void SetLoading(bool isLoading)
        {
            progressBar.Visible = isLoading;
            lblStatus.Visible = isLoading;

            btnSubmit.Enabled = !isLoading;
            btnSubmit.Text = isLoading ? "Predicting..." : "Submit";
        }

        private async void btnSubmit_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                SetLoading(true);

                var data = new DisasterRequest
                {
                    country = cbCountry.Text,
                    event_type = cbEvent.Text,
                    season = cbSeason.Text,
                    month = int.Parse(cbMonth.Text),
                    severity = numSeverity.Value,
                    duration_days = numDuration.Value,
                    affected_population = numPopulation.Value,
                    deaths = numDeaths.Value,
                    injuries = numInjuries.Value,
                    infrastructure_damage_score = numInfrastructure.Value,
                    response_time_hours = numResponseTime.Value,
                    international_aid_million_usd = numAidUSD.Value,
                    aid_percentage = numAidPercent.Value,
                    casualty_rate = numCasualtyRate.Value,
                    impact_per_capita = numImpactPerCapita.Value,
                    latitude = numLatitude.Value,
                    longitude = numLongitude.Value
                };

                string json = JsonConvert.SerializeObject(data);

                using (HttpClient client = new HttpClient())
                {
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    string apiUrl = "https://mohsinramzan-climateimpact.hf.space/predict";

                    var response = await client.PostAsync(apiUrl, content);
                    string result = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        dynamic prediction = JsonConvert.DeserializeObject(result);
                       
                        decimal casualties = prediction.total_casualties != null ? (decimal)prediction.total_casualties : 0;
                        decimal economicLoss = prediction.total_economic_loss != null ? (decimal)prediction.total_economic_loss : 0;
                       
                        string message = " MDIPS Prediction Results\n" +
                                         "─────────────────────────────\n" +
                                         $"Total Casualties     :  {casualties:N0}\n" +
                                         $"Total Economic Loss  :  ${economicLoss:N2} Million\n" +
                                         "─────────────────────────────\n" +
                                         "Prediction generated by Multitask Neural Network";

                        MessageBox.Show(message, "Prediction Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dynamic error = JsonConvert.DeserializeObject(result);
                        string errorMessage = error?.detail ?? result;

                        MessageBox.Show("Prediction failed.\n\nReason: " + errorMessage,
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                SetLoading(false);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}