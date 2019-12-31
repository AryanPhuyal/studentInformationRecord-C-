namespace StudentInformation
{
    partial class Home
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
            this.DGVStudentDetail = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudentDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVStudentDetail
            // 
            this.DGVStudentDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStudentDetail.Location = new System.Drawing.Point(0, -3);
            this.DGVStudentDetail.Name = "DGVStudentDetail";
            this.DGVStudentDetail.ReadOnly = true;
            this.DGVStudentDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGVStudentDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.DGVStudentDetail.Size = new System.Drawing.Size(1017, 374);
            this.DGVStudentDetail.TabIndex = 0;
            this.DGVStudentDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClickAction);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DGVStudentDetail);
            this.Location = new System.Drawing.Point(171, 99);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1018, 374);
            ((System.ComponentModel.ISupportInitialize)(this.DGVStudentDetail)).EndInit();
            this.ResumeLayout(false);

        }
        public void AddToTable( string data)
        {
            this.DGVStudentDetail.Rows.Add();
        }

        #endregion

        public System.Windows.Forms.DataGridView DGVStudentDetail;
    }
}