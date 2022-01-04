using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SampleChartNet5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Chart InitChart()
        {
            Chart chart1 = new();
            ChartArea chartArea1 = new();
            Legend legend1 = new();
            Series series1 = new();

            chartArea1.Name = "ChartArea1";
            legend1.Name = "Legend1";
            chart1.Name = "chart1";

            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.MarkerBorderWidth = 5;
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.MarkerSize = 2;
            series1.MarkerStyle = MarkerStyle.Circle;
            series1.Name = "value";

            chart1.ChartAreas.Add(chartArea1);
            chart1.Legends.Add(legend1);
            chart1.Series.Add(series1);

            chart1.Location = new System.Drawing.Point(10, 5);
            chart1.Size = new (this.Size.Width - 36, this.Size.Height - 50);

            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            this.Controls.Add(chart1);
            return chart1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Chart chart = InitChart();
            chart.Series[0].Points.AddXY("Step1", 100);
            chart.Series[0].Points.AddXY("Step2", 200);
            chart.Series[0].Points.AddXY("Step3", 50);
            chart.Series[0].Points.AddXY("Step4", 250);
        }
    }
}
