namespace StudentInformation
{
    partial class Chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.studentChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ProgramEnrolled = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.studentChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramEnrolled)).BeginInit();
            this.SuspendLayout();
            // 
            // studentChart
            // 
            chartArea1.Name = "ChartArea1";
            this.studentChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.studentChart.Legends.Add(legend1);
            this.studentChart.Location = new System.Drawing.Point(36, 23);
            this.studentChart.Name = "studentChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.studentChart.Series.Add(series1);
            this.studentChart.Size = new System.Drawing.Size(300, 300);
            this.studentChart.TabIndex = 0;
            this.studentChart.Text = "chart1";
            // 
            // ProgramEnrolled
            // 
            chartArea2.Name = "ChartArea1";
            this.ProgramEnrolled.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ProgramEnrolled.Legends.Add(legend2);
            this.ProgramEnrolled.Location = new System.Drawing.Point(402, 23);
            this.ProgramEnrolled.Name = "ProgramEnrolled";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ProgramEnrolled.Series.Add(series2);
            this.ProgramEnrolled.Size = new System.Drawing.Size(300, 300);
            this.ProgramEnrolled.TabIndex = 1;
            this.ProgramEnrolled.Text = "ProgramEnrolled";
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProgramEnrolled);
            this.Controls.Add(this.studentChart);
            this.Name = "Chart";
            this.Size = new System.Drawing.Size(833, 374);
            ((System.ComponentModel.ISupportInitialize)(this.studentChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramEnrolled)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart studentChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ProgramEnrolled;
    }
}
