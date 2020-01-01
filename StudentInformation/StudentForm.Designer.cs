namespace StudentInformation
{
    partial class StudentForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.BtnChart = new System.Windows.Forms.Button();
            this.BtnAddStudent = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbSort = new System.Windows.Forms.ComboBox();
            this.BtnSort = new System.Windows.Forms.Button();
            this.home1 = new StudentInformation.Home();
            this.chart1 = new StudentInformation.Chart();
            this.addStudent1 = new StudentInformation.AddStudent();
            this.BtnReport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.BtnReport);
            this.panel1.Controls.Add(this.BtnChart);
            this.panel1.Controls.Add(this.BtnAddStudent);
            this.panel1.Controls.Add(this.BtnHome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 553);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(170, 114);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(629, 391);
            this.panel5.TabIndex = 3;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SidePanel.Location = new System.Drawing.Point(3, 48);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 60);
            this.SidePanel.TabIndex = 2;
            // 
            // BtnChart
            // 
            this.BtnChart.FlatAppearance.BorderSize = 0;
            this.BtnChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChart.ForeColor = System.Drawing.Color.White;
            this.BtnChart.Location = new System.Drawing.Point(2, 190);
            this.BtnChart.Name = "BtnChart";
            this.BtnChart.Size = new System.Drawing.Size(162, 61);
            this.BtnChart.TabIndex = 1;
            this.BtnChart.Text = "Chart";
            this.BtnChart.UseVisualStyleBackColor = true;
            this.BtnChart.Click += new System.EventHandler(this.BtnChart_Click);
            // 
            // BtnAddStudent
            // 
            this.BtnAddStudent.FlatAppearance.BorderSize = 0;
            this.BtnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddStudent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddStudent.ForeColor = System.Drawing.Color.White;
            this.BtnAddStudent.Location = new System.Drawing.Point(3, 114);
            this.BtnAddStudent.Name = "BtnAddStudent";
            this.BtnAddStudent.Size = new System.Drawing.Size(162, 61);
            this.BtnAddStudent.TabIndex = 1;
            this.BtnAddStudent.Text = "Add Student";
            this.BtnAddStudent.UseVisualStyleBackColor = true;
            this.BtnAddStudent.Click += new System.EventHandler(this.BtnAddStudent_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.White;
            this.BtnHome.Location = new System.Drawing.Point(3, 48);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(162, 61);
            this.BtnHome.TabIndex = 1;
            this.BtnHome.Text = "Home";
            this.BtnHome.UseVisualStyleBackColor = true;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(170, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(167, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(996, 10);
            this.panel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Image = global::StudentInformation.Properties.Resources.download_50;
            this.button1.Location = new System.Drawing.Point(8, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 109);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.button1);
            this.panel4.ForeColor = System.Drawing.Color.DarkRed;
            this.panel4.Location = new System.Drawing.Point(167, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(132, 118);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(344, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(734, 86);
            this.label1.TabIndex = 7;
            this.label1.Text = "IslingTon College";
            // 
            // CmbSort
            // 
            this.CmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSort.FormattingEnabled = true;
            this.CmbSort.Items.AddRange(new object[] {
            "Name",
            "Registration Date"});
            this.CmbSort.Location = new System.Drawing.Point(435, 128);
            this.CmbSort.Name = "CmbSort";
            this.CmbSort.Size = new System.Drawing.Size(121, 21);
            this.CmbSort.TabIndex = 8;
            this.CmbSort.Visible = false;
            // 
            // BtnSort
            // 
            this.BtnSort.Location = new System.Drawing.Point(605, 128);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(75, 23);
            this.BtnSort.TabIndex = 9;
            this.BtnSort.Text = "Sort";
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Visible = false;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // home1
            // 
            this.home1.Location = new System.Drawing.Point(184, 166);
            this.home1.MainForm = null;
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(948, 374);
            this.home1.TabIndex = 6;
            // 
            // chart1
            // 
            this.chart1.Location = new System.Drawing.Point(228, 166);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(833, 374);
            this.chart1.TabIndex = 5;
            // 
            // addStudent1
            // 
            this.addStudent1.ForeColor = System.Drawing.Color.Black;
            this.addStudent1.Location = new System.Drawing.Point(228, 155);
            this.addStudent1.MainForm = null;
            this.addStudent1.Name = "addStudent1";
            this.addStudent1.Size = new System.Drawing.Size(833, 385);
            this.addStudent1.TabIndex = 1;
            // 
            // BtnReport
            // 
            this.BtnReport.FlatAppearance.BorderSize = 0;
            this.BtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReport.ForeColor = System.Drawing.Color.White;
            this.BtnReport.Location = new System.Drawing.Point(0, 257);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(162, 61);
            this.BtnReport.TabIndex = 1;
            this.BtnReport.Text = "Report";
            this.BtnReport.UseVisualStyleBackColor = true;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentInformation.Properties.Resources.slider1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1163, 552);
            this.Controls.Add(this.BtnSort);
            this.Controls.Add(this.CmbSort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.addStudent1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "StudentForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button BtnAddStudent;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnChart;
        private AddStudent addStudent1;
        private System.Windows.Forms.Button button1;
        private Chart chart1;
        private Home home1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbSort;
        private System.Windows.Forms.Button BtnSort;
        private System.Windows.Forms.Button BtnReport;
    }
}

