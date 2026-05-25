using System.Configuration;
using System.Windows;
using System.Windows.Forms;
namespace MDIPS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.cbEvent = new System.Windows.Forms.ComboBox();
            this.cbSeason = new System.Windows.Forms.ComboBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.numSeverity = new System.Windows.Forms.NumericUpDown();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.numPopulation = new System.Windows.Forms.NumericUpDown();
            this.numDeaths = new System.Windows.Forms.NumericUpDown();
            this.numInjuries = new System.Windows.Forms.NumericUpDown();
            this.numInfrastructure = new System.Windows.Forms.NumericUpDown();
            this.numResponseTime = new System.Windows.Forms.NumericUpDown();
            this.numAidUSD = new System.Windows.Forms.NumericUpDown();
            this.numAidPercent = new System.Windows.Forms.NumericUpDown();
            this.numCasualtyRate = new System.Windows.Forms.NumericUpDown();
            this.numImpactPerCapita = new System.Windows.Forms.NumericUpDown();
            this.numLatitude = new System.Windows.Forms.NumericUpDown();
            this.numLongitude = new System.Windows.Forms.NumericUpDown();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblSeason = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblSeverity = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblPopulation = new System.Windows.Forms.Label();
            this.lblDeaths = new System.Windows.Forms.Label();
            this.lblInjuries = new System.Windows.Forms.Label();
            this.lblInfrastructure = new System.Windows.Forms.Label();
            this.lblResponseTime = new System.Windows.Forms.Label();
            this.lblAidUSD = new System.Windows.Forms.Label();
            this.lblAidPercent = new System.Windows.Forms.Label();
            this.lblCasualtyRate = new System.Windows.Forms.Label();
            this.lblImpactPerCapita = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSeverity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeaths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInjuries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInfrastructure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResponseTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAidUSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAidPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCasualtyRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numImpactPerCapita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLatitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLongitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCountry
            // 
            this.cbCountry.Location = new System.Drawing.Point(108, 94);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(150, 28);
            this.cbCountry.TabIndex = 0;
            // 
            // cbEvent
            // 
            this.cbEvent.Items.AddRange(new object[] {
            "Flood",
            "Earthquake",
            "Fire",
            "Storm"});
            this.cbEvent.Location = new System.Drawing.Point(108, 140);
            this.cbEvent.Name = "cbEvent";
            this.cbEvent.Size = new System.Drawing.Size(150, 28);
            this.cbEvent.TabIndex = 1;
            // 
            // cbSeason
            // 
            this.cbSeason.Items.AddRange(new object[] {
            "Winter",
            "Spring",
            "Summer",
            "Autumn"});
            this.cbSeason.Location = new System.Drawing.Point(108, 189);
            this.cbSeason.Name = "cbSeason";
            this.cbSeason.Size = new System.Drawing.Size(150, 28);
            this.cbSeason.TabIndex = 2;
            // 
            // cbMonth
            // 
            this.cbMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbMonth.Location = new System.Drawing.Point(108, 238);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(150, 28);
            this.cbMonth.TabIndex = 3;
            // 
            // numSeverity
            // 
            this.numSeverity.DecimalPlaces = 2;
            this.numSeverity.Location = new System.Drawing.Point(438, 144);
            this.numSeverity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSeverity.Name = "numSeverity";
            this.numSeverity.Size = new System.Drawing.Size(120, 26);
            this.numSeverity.TabIndex = 4;
            // 
            // numDuration
            // 
            this.numDuration.Location = new System.Drawing.Point(438, 192);
            this.numDuration.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(120, 26);
            this.numDuration.TabIndex = 5;
            // 
            // numPopulation
            // 
            this.numPopulation.Location = new System.Drawing.Point(438, 241);
            this.numPopulation.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numPopulation.Name = "numPopulation";
            this.numPopulation.Size = new System.Drawing.Size(120, 26);
            this.numPopulation.TabIndex = 6;
            // 
            // numDeaths
            // 
            this.numDeaths.Location = new System.Drawing.Point(438, 293);
            this.numDeaths.Name = "numDeaths";
            this.numDeaths.Size = new System.Drawing.Size(120, 26);
            this.numDeaths.TabIndex = 7;
            // 
            // numInjuries
            // 
            this.numInjuries.Location = new System.Drawing.Point(438, 350);
            this.numInjuries.Name = "numInjuries";
            this.numInjuries.Size = new System.Drawing.Size(120, 26);
            this.numInjuries.TabIndex = 8;
            // 
            // numInfrastructure
            // 
            this.numInfrastructure.Location = new System.Drawing.Point(774, 100);
            this.numInfrastructure.Name = "numInfrastructure";
            this.numInfrastructure.Size = new System.Drawing.Size(120, 26);
            this.numInfrastructure.TabIndex = 9;
            // 
            // numResponseTime
            // 
            this.numResponseTime.Location = new System.Drawing.Point(774, 145);
            this.numResponseTime.Name = "numResponseTime";
            this.numResponseTime.Size = new System.Drawing.Size(120, 26);
            this.numResponseTime.TabIndex = 10;
            // 
            // numAidUSD
            // 
            this.numAidUSD.Location = new System.Drawing.Point(774, 192);
            this.numAidUSD.Name = "numAidUSD";
            this.numAidUSD.Size = new System.Drawing.Size(120, 26);
            this.numAidUSD.TabIndex = 11;
            // 
            // numAidPercent
            // 
            this.numAidPercent.Location = new System.Drawing.Point(774, 246);
            this.numAidPercent.Name = "numAidPercent";
            this.numAidPercent.Size = new System.Drawing.Size(120, 26);
            this.numAidPercent.TabIndex = 12;
            // 
            // numCasualtyRate
            // 
            this.numCasualtyRate.DecimalPlaces = 4;
            this.numCasualtyRate.Location = new System.Drawing.Point(774, 294);
            this.numCasualtyRate.Name = "numCasualtyRate";
            this.numCasualtyRate.Size = new System.Drawing.Size(120, 26);
            this.numCasualtyRate.TabIndex = 13;
            // 
            // numImpactPerCapita
            // 
            this.numImpactPerCapita.Location = new System.Drawing.Point(774, 344);
            this.numImpactPerCapita.Name = "numImpactPerCapita";
            this.numImpactPerCapita.Size = new System.Drawing.Size(120, 26);
            this.numImpactPerCapita.TabIndex = 14;
            // 
            // numLatitude
            // 
            this.numLatitude.DecimalPlaces = 6;
            this.numLatitude.Location = new System.Drawing.Point(108, 297);
            this.numLatitude.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numLatitude.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.numLatitude.Name = "numLatitude";
            this.numLatitude.Size = new System.Drawing.Size(120, 26);
            this.numLatitude.TabIndex = 15;
            // 
            // numLongitude
            // 
            this.numLongitude.DecimalPlaces = 6;
            this.numLongitude.Location = new System.Drawing.Point(108, 344);
            this.numLongitude.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numLongitude.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.numLongitude.Name = "numLongitude";
            this.numLongitude.Size = new System.Drawing.Size(120, 26);
            this.numLongitude.TabIndex = 16;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(385, 477);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(223, 48);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_ClickAsync);
            // 
            // lblCountry
            // 
            this.lblCountry.Location = new System.Drawing.Point(38, 97);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(100, 23);
            this.lblCountry.TabIndex = 18;
            this.lblCountry.Text = "Country";
            // 
            // lblEvent
            // 
            this.lblEvent.Location = new System.Drawing.Point(12, 148);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(100, 23);
            this.lblEvent.TabIndex = 19;
            this.lblEvent.Text = "Event Type";
            // 
            // lblSeason
            // 
            this.lblSeason.Location = new System.Drawing.Point(38, 189);
            this.lblSeason.Name = "lblSeason";
            this.lblSeason.Size = new System.Drawing.Size(100, 23);
            this.lblSeason.TabIndex = 20;
            this.lblSeason.Text = "Season";
            // 
            // lblMonth
            // 
            this.lblMonth.Location = new System.Drawing.Point(50, 238);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(100, 23);
            this.lblMonth.TabIndex = 21;
            this.lblMonth.Text = "Month";
            // 
            // lblSeverity
            // 
            this.lblSeverity.Location = new System.Drawing.Point(360, 144);
            this.lblSeverity.Name = "lblSeverity";
            this.lblSeverity.Size = new System.Drawing.Size(100, 23);
            this.lblSeverity.TabIndex = 22;
            this.lblSeverity.Text = "Severity";
            // 
            // lblDuration
            // 
            this.lblDuration.Location = new System.Drawing.Point(360, 192);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(100, 23);
            this.lblDuration.TabIndex = 23;
            this.lblDuration.Text = "Duration (Days)";
            // 
            // lblPopulation
            // 
            this.lblPopulation.Location = new System.Drawing.Point(360, 243);
            this.lblPopulation.Name = "lblPopulation";
            this.lblPopulation.Size = new System.Drawing.Size(100, 23);
            this.lblPopulation.TabIndex = 24;
            this.lblPopulation.Text = "Affected Population";
            // 
            // lblDeaths
            // 
            this.lblDeaths.Location = new System.Drawing.Point(360, 296);
            this.lblDeaths.Name = "lblDeaths";
            this.lblDeaths.Size = new System.Drawing.Size(100, 23);
            this.lblDeaths.TabIndex = 25;
            this.lblDeaths.Text = "Deaths";
            // 
            // lblInjuries
            // 
            this.lblInjuries.Location = new System.Drawing.Point(360, 350);
            this.lblInjuries.Name = "lblInjuries";
            this.lblInjuries.Size = new System.Drawing.Size(100, 23);
            this.lblInjuries.TabIndex = 26;
            this.lblInjuries.Text = "Injuries";
            // 
            // lblInfrastructure
            // 
            this.lblInfrastructure.Location = new System.Drawing.Point(659, 100);
            this.lblInfrastructure.Name = "lblInfrastructure";
            this.lblInfrastructure.Size = new System.Drawing.Size(100, 23);
            this.lblInfrastructure.TabIndex = 27;
            this.lblInfrastructure.Text = "Infrastructure Damage";
            // 
            // lblResponseTime
            // 
            this.lblResponseTime.Location = new System.Drawing.Point(659, 147);
            this.lblResponseTime.Name = "lblResponseTime";
            this.lblResponseTime.Size = new System.Drawing.Size(100, 23);
            this.lblResponseTime.TabIndex = 28;
            this.lblResponseTime.Text = "Response Time (hrs)";
            // 
            // lblAidUSD
            // 
            this.lblAidUSD.Location = new System.Drawing.Point(668, 196);
            this.lblAidUSD.Name = "lblAidUSD";
            this.lblAidUSD.Size = new System.Drawing.Size(100, 23);
            this.lblAidUSD.TabIndex = 29;
            this.lblAidUSD.Text = "Aid (Million USD)";
            // 
            // lblAidPercent
            // 
            this.lblAidPercent.Location = new System.Drawing.Point(707, 249);
            this.lblAidPercent.Name = "lblAidPercent";
            this.lblAidPercent.Size = new System.Drawing.Size(100, 23);
            this.lblAidPercent.TabIndex = 30;
            this.lblAidPercent.Text = "Aid %";
            // 
            // lblCasualtyRate
            // 
            this.lblCasualtyRate.Location = new System.Drawing.Point(684, 297);
            this.lblCasualtyRate.Name = "lblCasualtyRate";
            this.lblCasualtyRate.Size = new System.Drawing.Size(100, 23);
            this.lblCasualtyRate.TabIndex = 31;
            this.lblCasualtyRate.Text = "Casualty Rate";
            // 
            // lblImpactPerCapita
            // 
            this.lblImpactPerCapita.Location = new System.Drawing.Point(634, 344);
            this.lblImpactPerCapita.Name = "lblImpactPerCapita";
            this.lblImpactPerCapita.Size = new System.Drawing.Size(150, 24);
            this.lblImpactPerCapita.TabIndex = 32;
            this.lblImpactPerCapita.Text = "Impact Per Capita";
            // 
            // lblLatitude
            // 
            this.lblLatitude.Location = new System.Drawing.Point(38, 300);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(100, 23);
            this.lblLatitude.TabIndex = 33;
            this.lblLatitude.Text = "Latitude";
            // 
            // lblLongitude
            // 
            this.lblLongitude.Location = new System.Drawing.Point(12, 344);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(100, 23);
            this.lblLongitude.TabIndex = 34;
            this.lblLongitude.Text = "Longitude";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.Location = new System.Drawing.Point(359, 22);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(397, 29);
            this.lblTable.TabIndex = 35;
            this.lblTable.Text = "Climate Change Impact Predictor";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(397, 416);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(198, 26);
            this.progressBar.TabIndex = 36;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(409, 454);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 20);
            this.lblStatus.TabIndex = 37;
            this.lblStatus.Text = "label1";
            this.lblStatus.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1143, 569);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.cbEvent);
            this.Controls.Add(this.cbSeason);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.numSeverity);
            this.Controls.Add(this.numDuration);
            this.Controls.Add(this.numPopulation);
            this.Controls.Add(this.numDeaths);
            this.Controls.Add(this.numInjuries);
            this.Controls.Add(this.numInfrastructure);
            this.Controls.Add(this.numResponseTime);
            this.Controls.Add(this.numAidUSD);
            this.Controls.Add(this.numAidPercent);
            this.Controls.Add(this.numCasualtyRate);
            this.Controls.Add(this.numImpactPerCapita);
            this.Controls.Add(this.numLatitude);
            this.Controls.Add(this.numLongitude);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.lblSeason);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblSeverity);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblPopulation);
            this.Controls.Add(this.lblDeaths);
            this.Controls.Add(this.lblInjuries);
            this.Controls.Add(this.lblInfrastructure);
            this.Controls.Add(this.lblResponseTime);
            this.Controls.Add(this.lblAidUSD);
            this.Controls.Add(this.lblAidPercent);
            this.Controls.Add(this.lblCasualtyRate);
            this.Controls.Add(this.lblImpactPerCapita);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.lblLongitude);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSeverity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeaths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInjuries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInfrastructure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResponseTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAidUSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAidPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCasualtyRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numImpactPerCapita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLatitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLongitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.ComboBox cbEvent;
        private System.Windows.Forms.ComboBox cbSeason;
        private System.Windows.Forms.ComboBox cbMonth;

        private System.Windows.Forms.NumericUpDown numSeverity;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.NumericUpDown numPopulation;
        private System.Windows.Forms.NumericUpDown numDeaths;
        private System.Windows.Forms.NumericUpDown numInjuries;

        private System.Windows.Forms.NumericUpDown numInfrastructure;
        private System.Windows.Forms.NumericUpDown numResponseTime;
        private System.Windows.Forms.NumericUpDown numAidUSD;
        private System.Windows.Forms.NumericUpDown numAidPercent;
        private System.Windows.Forms.NumericUpDown numCasualtyRate;
        private System.Windows.Forms.NumericUpDown numImpactPerCapita;

        private System.Windows.Forms.NumericUpDown numLatitude;
        private System.Windows.Forms.NumericUpDown numLongitude;

        private System.Windows.Forms.Button btnSubmit;

        // Labels that i was missing before

        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Label lblSeason;
        private System.Windows.Forms.Label lblMonth;

        private System.Windows.Forms.Label lblSeverity;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblPopulation;
        private System.Windows.Forms.Label lblDeaths;
        private System.Windows.Forms.Label lblInjuries;

        private System.Windows.Forms.Label lblInfrastructure;
        private System.Windows.Forms.Label lblResponseTime;
        private System.Windows.Forms.Label lblAidUSD;
        private System.Windows.Forms.Label lblAidPercent;
        private System.Windows.Forms.Label lblCasualtyRate;
        private System.Windows.Forms.Label lblImpactPerCapita;

        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblLongitude;
        private Label lblTable;
        private ProgressBar progressBar;
        private ErrorProvider errorProvider1;
        private Label lblStatus;
    }
}

