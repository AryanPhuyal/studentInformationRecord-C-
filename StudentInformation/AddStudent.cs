using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace StudentInformation
{
    public partial class AddStudent : UserControl
    {
        public StudentForm MainForm { get; set; }
        public AddStudent() {
            InitializeComponent();
        }
       
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            LblAddress_Error.Text = "";
            LblContact_Error.Text = "";
            LblEmail_Error.Text = "";
            LblEnrolled_Error.Text = "";
            LblFirstName_error.Text = "";
            LblGender_Error.Text = "";
            LblLastName_error.Text = "";
            LblRegistrationDate_Error.Text = "";

            if (Validation())
            {
                String firstName = TxtFirstName.Text;
                String lastName = TxtLastName.Text;
                String address = TxtAddress.Text;
                String email = TxtEmail.Text;
                String programEnrolled = CmbEnrolled.SelectedItem.ToString();
                DateTime enrolledDate = DpRegistrationDate.Value;
                string contact = TxtContact.Text;
                string gender= RbFemale.Checked?"Female":"Male";
                Student obj = new Student();
                obj.Name = firstName + " " + lastName;
                obj.Address = address;
                obj.Email = email;
                obj.ProgramEnrolled = CmbEnrolled.SelectedItem.ToString();
                obj.RegistrationDate = DpRegistrationDate.Value;
                obj.BirthDate = DTPDateOfBirth.Value;
                obj.ContactNo = contact;
                obj.Gender = gender;
                if (BtnAdd.Text != "Edit")
                {
                    obj.Add(obj);
                    //  Clear();
                }
                else
                {
                    obj.Id = int.Parse(TextId.Text);
                    obj.Edit(obj);
                    MainForm.btnHomeClicked();  

                }
                this.MainForm.BindGrid();
                Clear();


            }
        }
        public void Clear()
        {
            TxtFirstName.Text = "";
            TxtLastName.Text = "";
            TxtContact.Text = "";
            TxtAddress.Text = "";
            TxtEmail.Text = "";
            CmbEnrolled.SelectedItem = "";
            RbFemale.Checked = false;
            RbMail.Checked = false;
            DpRegistrationDate.Value = DateTime.Now;
            DTPDateOfBirth.Value = DateTime.Now;
            
        }
        private bool Validation()
        {
            bool validation_result = true;
            if (TxtFirstName.Text.Length < 3 || TxtFirstName.Text.Length > 50)
            {
                LblFirstName_error.Text = "First Name should be of length 3 and 50";
                validation_result = false;
            }
            if (TxtLastName.Text.Length<3 ||  TxtLastName.Text.Length > 50)
            {
                LblLastName_error.Text = "Last Name should be of length 3 and 50";
                validation_result = false;
            }
            if(TxtContact.Text.Length != 10)
            {
                validation_result = false;
                LblContact_Error.Text = "Contact should be of 10 digit";
            }
            if (TxtAddress.Text.Length<2)
            {
                validation_result = false;
                LblAddress_Error.Text = "Please Type correct Contact Address";
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(TxtEmail.Text);
            }
            catch
            {
                LblEmail_Error.Text = "Please Select Correct email Address";
                validation_result = false;
            }
            try
            {
                String programEnrolled = CmbEnrolled.SelectedItem.ToString();

            }
            catch
            {
                LblEnrolled_Error.Text = "Select Program which you wish to Enroll";
                validation_result = false;
            }
            if(!RbFemale.Checked && !RbMail.Checked)
            {
                validation_result = false;
                LblGender_Error.Text = "Please Select Any gender";
            }

            return validation_result;
        }
       
        private void TxtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            MainForm.Delete(int.Parse(TextId.Text));
            MainForm.btnHomeClicked();

        }
    }
}
