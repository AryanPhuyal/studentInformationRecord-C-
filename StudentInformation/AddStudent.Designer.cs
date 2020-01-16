namespace StudentInformation
{
    partial class AddStudent
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
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtContact = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbEnrolled = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DpRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.RbMail = new System.Windows.Forms.RadioButton();
            this.RbFemale = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.StudentInfoGB = new System.Windows.Forms.GroupBox();
            this.lblErrorEnrollStatus = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CbEnrollStatus = new System.Windows.Forms.ComboBox();
            this.TextId = new System.Windows.Forms.TextBox();
            this.DTPDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.LblEnrolled_Error = new System.Windows.Forms.Label();
            this.LblGender_Error = new System.Windows.Forms.Label();
            this.LblRegistrationDate_Error = new System.Windows.Forms.Label();
            this.LblEmail_Error = new System.Windows.Forms.Label();
            this.LblContact_Error = new System.Windows.Forms.Label();
            this.LblAddress_Error = new System.Windows.Forms.Label();
            this.LblLastName_error = new System.Windows.Forms.Label();
            this.LblFirstName_error = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.StudentInfoGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFirstName.Location = new System.Drawing.Point(143, 47);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(183, 22);
            this.TxtFirstName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLastName.Location = new System.Drawing.Point(143, 104);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(183, 22);
            this.TxtLastName.TabIndex = 1;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddress.Location = new System.Drawing.Point(143, 162);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(183, 22);
            this.TxtAddress.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contact No";
            // 
            // TxtContact
            // 
            this.TxtContact.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContact.Location = new System.Drawing.Point(143, 219);
            this.TxtContact.Name = "TxtContact";
            this.TxtContact.Size = new System.Drawing.Size(183, 22);
            this.TxtContact.TabIndex = 3;
            this.TxtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContact_KeyPress);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(143, 286);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(183, 22);
            this.TxtEmail.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email";
            // 
            // CmbEnrolled
            // 
            this.CmbEnrolled.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEnrolled.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEnrolled.FormattingEnabled = true;
            this.CmbEnrolled.Items.AddRange(new object[] {
            "Multimedia",
            "Computing",
            "BBA",
            "Networking"});
            this.CmbEnrolled.Location = new System.Drawing.Point(569, 231);
            this.CmbEnrolled.Name = "CmbEnrolled";
            this.CmbEnrolled.Size = new System.Drawing.Size(200, 24);
            this.CmbEnrolled.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(430, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Program Enrolled";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(430, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Registration Date";
            // 
            // DpRegistrationDate
            // 
            this.DpRegistrationDate.CalendarFont = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DpRegistrationDate.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DpRegistrationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DpRegistrationDate.Location = new System.Drawing.Point(569, 292);
            this.DpRegistrationDate.Name = "DpRegistrationDate";
            this.DpRegistrationDate.Size = new System.Drawing.Size(200, 22);
            this.DpRegistrationDate.TabIndex = 4;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(656, 338);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(113, 32);
            this.BtnAdd.TabIndex = 11;
            this.BtnAdd.Text = "Add Student";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // RbMail
            // 
            this.RbMail.AutoSize = true;
            this.RbMail.Location = new System.Drawing.Point(143, 344);
            this.RbMail.Name = "RbMail";
            this.RbMail.Size = new System.Drawing.Size(56, 24);
            this.RbMail.TabIndex = 5;
            this.RbMail.TabStop = true;
            this.RbMail.Text = "Male";
            this.RbMail.UseVisualStyleBackColor = true;
            // 
            // RbFemale
            // 
            this.RbFemale.AutoSize = true;
            this.RbFemale.Location = new System.Drawing.Point(216, 342);
            this.RbFemale.Name = "RbFemale";
            this.RbFemale.Size = new System.Drawing.Size(72, 24);
            this.RbFemale.TabIndex = 4;
            this.RbFemale.TabStop = true;
            this.RbFemale.Text = "Female";
            this.RbFemale.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Gender";
            // 
            // StudentInfoGB
            // 
            this.StudentInfoGB.Controls.Add(this.lblErrorEnrollStatus);
            this.StudentInfoGB.Controls.Add(this.label10);
            this.StudentInfoGB.Controls.Add(this.CbEnrollStatus);
            this.StudentInfoGB.Controls.Add(this.TextId);
            this.StudentInfoGB.Controls.Add(this.DTPDateOfBirth);
            this.StudentInfoGB.Controls.Add(this.DpRegistrationDate);
            this.StudentInfoGB.Controls.Add(this.BtnDelete);
            this.StudentInfoGB.Controls.Add(this.BtnAdd);
            this.StudentInfoGB.Controls.Add(this.label9);
            this.StudentInfoGB.Controls.Add(this.label7);
            this.StudentInfoGB.Controls.Add(this.RbFemale);
            this.StudentInfoGB.Controls.Add(this.CmbEnrolled);
            this.StudentInfoGB.Controls.Add(this.LblEnrolled_Error);
            this.StudentInfoGB.Controls.Add(this.RbMail);
            this.StudentInfoGB.Controls.Add(this.LblGender_Error);
            this.StudentInfoGB.Controls.Add(this.LblRegistrationDate_Error);
            this.StudentInfoGB.Controls.Add(this.label6);
            this.StudentInfoGB.Controls.Add(this.LblEmail_Error);
            this.StudentInfoGB.Controls.Add(this.LblContact_Error);
            this.StudentInfoGB.Controls.Add(this.LblAddress_Error);
            this.StudentInfoGB.Controls.Add(this.LblLastName_error);
            this.StudentInfoGB.Controls.Add(this.LblFirstName_error);
            this.StudentInfoGB.Controls.Add(this.TxtEmail);
            this.StudentInfoGB.Controls.Add(this.label8);
            this.StudentInfoGB.Controls.Add(this.panel1);
            this.StudentInfoGB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentInfoGB.Location = new System.Drawing.Point(3, 3);
            this.StudentInfoGB.Name = "StudentInfoGB";
            this.StudentInfoGB.Size = new System.Drawing.Size(807, 374);
            this.StudentInfoGB.TabIndex = 9;
            this.StudentInfoGB.TabStop = false;
            this.StudentInfoGB.Text = "Student Information";
            this.StudentInfoGB.Enter += new System.EventHandler(this.StudentInfoGB_Enter);
            // 
            // lblErrorEnrollStatus
            // 
            this.lblErrorEnrollStatus.AutoSize = true;
            this.lblErrorEnrollStatus.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEnrollStatus.Location = new System.Drawing.Point(566, 101);
            this.lblErrorEnrollStatus.Name = "lblErrorEnrollStatus";
            this.lblErrorEnrollStatus.Size = new System.Drawing.Size(0, 16);
            this.lblErrorEnrollStatus.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(454, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Enroll Status";
            // 
            // CbEnrollStatus
            // 
            this.CbEnrollStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbEnrollStatus.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbEnrollStatus.FormattingEnabled = true;
            this.CbEnrollStatus.Items.AddRange(new object[] {
            "Enrolled",
            "Pending",
            "Not Enrolled"});
            this.CbEnrollStatus.Location = new System.Drawing.Point(569, 123);
            this.CbEnrollStatus.Name = "CbEnrollStatus";
            this.CbEnrollStatus.Size = new System.Drawing.Size(200, 24);
            this.CbEnrollStatus.TabIndex = 20;
            // 
            // TextId
            // 
            this.TextId.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextId.Location = new System.Drawing.Point(400, 17);
            this.TextId.Name = "TextId";
            this.TextId.Size = new System.Drawing.Size(42, 22);
            this.TextId.TabIndex = 0;
            this.TextId.Visible = false;
            // 
            // DTPDateOfBirth
            // 
            this.DTPDateOfBirth.CalendarFont = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPDateOfBirth.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPDateOfBirth.Location = new System.Drawing.Point(569, 182);
            this.DTPDateOfBirth.Name = "DTPDateOfBirth";
            this.DTPDateOfBirth.Size = new System.Drawing.Size(200, 22);
            this.DTPDateOfBirth.TabIndex = 8;
            this.DTPDateOfBirth.Value = new System.DateTime(2019, 12, 28, 0, 0, 0, 0);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(513, 338);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(113, 32);
            this.BtnDelete.TabIndex = 11;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Visible = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(451, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Date Of Birth";
            // 
            // LblEnrolled_Error
            // 
            this.LblEnrolled_Error.AutoSize = true;
            this.LblEnrolled_Error.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnrolled_Error.ForeColor = System.Drawing.Color.Red;
            this.LblEnrolled_Error.Location = new System.Drawing.Point(603, 214);
            this.LblEnrolled_Error.Name = "LblEnrolled_Error";
            this.LblEnrolled_Error.Size = new System.Drawing.Size(0, 16);
            this.LblEnrolled_Error.TabIndex = 13;
            // 
            // LblGender_Error
            // 
            this.LblGender_Error.AutoSize = true;
            this.LblGender_Error.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGender_Error.ForeColor = System.Drawing.Color.Red;
            this.LblGender_Error.Location = new System.Drawing.Point(294, 344);
            this.LblGender_Error.Name = "LblGender_Error";
            this.LblGender_Error.Size = new System.Drawing.Size(0, 16);
            this.LblGender_Error.TabIndex = 12;
            // 
            // LblRegistrationDate_Error
            // 
            this.LblRegistrationDate_Error.AutoSize = true;
            this.LblRegistrationDate_Error.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistrationDate_Error.ForeColor = System.Drawing.Color.Red;
            this.LblRegistrationDate_Error.Location = new System.Drawing.Point(603, 275);
            this.LblRegistrationDate_Error.Name = "LblRegistrationDate_Error";
            this.LblRegistrationDate_Error.Size = new System.Drawing.Size(0, 16);
            this.LblRegistrationDate_Error.TabIndex = 14;
            // 
            // LblEmail_Error
            // 
            this.LblEmail_Error.AutoSize = true;
            this.LblEmail_Error.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail_Error.ForeColor = System.Drawing.Color.Red;
            this.LblEmail_Error.Location = new System.Drawing.Point(140, 264);
            this.LblEmail_Error.Name = "LblEmail_Error";
            this.LblEmail_Error.Size = new System.Drawing.Size(0, 16);
            this.LblEmail_Error.TabIndex = 12;
            // 
            // LblContact_Error
            // 
            this.LblContact_Error.AutoSize = true;
            this.LblContact_Error.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContact_Error.ForeColor = System.Drawing.Color.Red;
            this.LblContact_Error.Location = new System.Drawing.Point(140, 200);
            this.LblContact_Error.Name = "LblContact_Error";
            this.LblContact_Error.Size = new System.Drawing.Size(0, 16);
            this.LblContact_Error.TabIndex = 16;
            // 
            // LblAddress_Error
            // 
            this.LblAddress_Error.AutoSize = true;
            this.LblAddress_Error.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddress_Error.ForeColor = System.Drawing.Color.Red;
            this.LblAddress_Error.Location = new System.Drawing.Point(140, 143);
            this.LblAddress_Error.Name = "LblAddress_Error";
            this.LblAddress_Error.Size = new System.Drawing.Size(0, 16);
            this.LblAddress_Error.TabIndex = 12;
            // 
            // LblLastName_error
            // 
            this.LblLastName_error.AutoSize = true;
            this.LblLastName_error.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLastName_error.ForeColor = System.Drawing.Color.Red;
            this.LblLastName_error.Location = new System.Drawing.Point(140, 85);
            this.LblLastName_error.Name = "LblLastName_error";
            this.LblLastName_error.Size = new System.Drawing.Size(0, 16);
            this.LblLastName_error.TabIndex = 17;
            // 
            // LblFirstName_error
            // 
            this.LblFirstName_error.AutoSize = true;
            this.LblFirstName_error.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFirstName_error.ForeColor = System.Drawing.Color.Red;
            this.LblFirstName_error.Location = new System.Drawing.Point(140, 28);
            this.LblFirstName_error.Name = "LblFirstName_error";
            this.LblFirstName_error.Size = new System.Drawing.Size(0, 16);
            this.LblFirstName_error.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(122, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 48);
            this.panel1.TabIndex = 10;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtContact);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.StudentInfoGB);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AddStudent";
            this.Size = new System.Drawing.Size(811, 388);
            this.StudentInfoGB.ResumeLayout(false);
            this.StudentInfoGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtLastName;
        public System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtContact;
        public System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox CmbEnrolled;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DateTimePicker DpRegistrationDate;
        public System.Windows.Forms.Button BtnAdd;
        public System.Windows.Forms.RadioButton RbFemale;
        public System.Windows.Forms.RadioButton RbMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox StudentInfoGB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label LblEnrolled_Error;
        private System.Windows.Forms.Label LblGender_Error;
        private System.Windows.Forms.Label LblRegistrationDate_Error;
        private System.Windows.Forms.Label LblEmail_Error;
        private System.Windows.Forms.Label LblContact_Error;
        private System.Windows.Forms.Label LblAddress_Error;
        private System.Windows.Forms.Label LblLastName_error;
        private System.Windows.Forms.Label LblFirstName_error;
        public System.Windows.Forms.TextBox TextId;
        public System.Windows.Forms.Button BtnDelete;
        public System.Windows.Forms.DateTimePicker DTPDateOfBirth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblErrorEnrollStatus;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox CbEnrollStatus;
    }
}
