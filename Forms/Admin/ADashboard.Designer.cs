using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace SanaPass_EBAAMS
{
    partial class ADashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartRequestsTrend = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartRequestsTrend)).BeginInit();
            this.SuspendLayout();
            // 
            // chartRequestsTrend
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRequestsTrend.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRequestsTrend.Legends.Add(legend1);
            this.chartRequestsTrend.Location = new System.Drawing.Point(3, 3);
            this.chartRequestsTrend.Name = "chartRequestsTrend";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRequestsTrend.Series.Add(series1);
            this.chartRequestsTrend.Size = new System.Drawing.Size(300, 300);
            this.chartRequestsTrend.TabIndex = 0;
            this.chartRequestsTrend.Text = "chart1";
            // 
            // ADashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.chartRequestsTrend);
            this.Name = "ADashboard";
            this.Size = new System.Drawing.Size(1008, 589);
            ((System.ComponentModel.ISupportInitialize)(this.chartRequestsTrend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartRequestsTrend;

        private void SetupDashboardChart()
        {
            // Clear default series and chart areas
            chartRequestsTrend.Series.Clear();
            chartRequestsTrend.ChartAreas.Clear();

            // 1. Create and Style Chart Area
            ChartArea chartArea = new ChartArea("MainArea");
            chartArea.BackColor = Color.White;

            // Subtle gridlines
            chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(240, 240, 240);
            chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(240, 240, 240);

            // Clean axis labels font
            chartArea.AxisX.LabelStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            chartArea.AxisX.LabelStyle.ForeColor = Color.FromArgb(100, 116, 139);
            chartArea.AxisY.LabelStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            chartArea.AxisY.LabelStyle.ForeColor = Color.FromArgb(100, 116, 139);

            chartRequestsTrend.ChartAreas.Add(chartArea);

            // 2. Create Data Series (Bar Chart for Category Counts or Spline Area for Monthly Trends)
            Series series = new Series("Monthly Borrowed")
            {
                ChartType = SeriesChartType.SplineArea, // Smooth filled line chart
                BorderWidth = 3,
                Color = Color.FromArgb(99, 102, 241), // Indigo line accent
                BackSecondaryColor = Color.FromArgb(224, 231, 255), // Light gradient fill
                BackGradientStyle = GradientStyle.TopBottom
            };

            // Sample Data Points (Replace with database query results)
            series.Points.AddXY("Mon", 12);
            series.Points.AddXY("Tue", 19);
            series.Points.AddXY("Wed", 8);
            series.Points.AddXY("Thu", 15);
            series.Points.AddXY("Fri", 22);
            series.Points.AddXY("Sat", 6);

            chartRequestsTrend.Series.Add(series);

            // 3. Overall Chart Container Background
            chartRequestsTrend.BackColor = Color.White;
            chartRequestsTrend.BorderlineColor = Color.FromArgb(226, 232, 240);
            chartRequestsTrend.BorderlineDashStyle = ChartDashStyle.Solid;
            chartRequestsTrend.BorderlineWidth = 1;
        }
    }
}
