using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation
{

    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            btnHomeClicked();
            BindGrid();
            Chart();
            home1.MainForm = this;
            addStudent1.MainForm = this;
        }

        public void btnHomeClicked()
        {
            CmbSort.Visible = true;
            BtnSort.Visible = true;
            SidePanel.Top = BtnHome.Top;
            SidePanel.Height = BtnHome.Height;
            this.home1.BringToFront();
            BtnAddStudent.Text = "Add Student";
            addStudent1.BtnAdd.Text = "Add Student";
            addStudent1.BtnDelete.Visible = false;
            this.home1.Visible = true;
            this.addStudent1.Visible = false;
            this.chart1.Visible = false;
            
        }
        private void BtnHome_Click(object sender, EventArgs e)
        {
            btnHomeClicked();
        }
        private void btnAddStudentClicked()
        {
            CmbSort.Visible = false;
            BtnSort.Visible = false;
            SidePanel.Top = BtnAddStudent.Top;
            SidePanel.Height = BtnAddStudent.Height;
            this.addStudent1.BringToFront();
            this.home1.Visible = false;
            this.addStudent1.Visible = true;
            this.chart1.Visible = false;
            
        }
        private void  Chart() {
            Student obj = new Student();
            List<Student> listStudents = obj.List();
            this.chart1.BindChart(listStudents);
        }
        private void BtnAddStudent_Click(object sender, EventArgs e)
        {
            btnAddStudentClicked();
        }
        public void Edit(int id)
        {
            Student obj = new Student();
            Student s = obj.List().Where(x => x.Id == id).FirstOrDefault();
            addStudent1.TextId.Text = s.Id+"";
            addStudent1.TxtFirstName.Text = s.Name.Split(' ')[0];
            addStudent1.TxtLastName.Text = s.Name.Split(' ')[1];
            addStudent1.TxtAddress.Text = s.Address;
            addStudent1.TxtContact.Text = s.ContactNo;
            addStudent1.TxtEmail.Text = s.Email;
            addStudent1.CmbEnrolled.SelectedItem = s.ProgramEnrolled;
            addStudent1.DTPDateOfBirth.Value = s.BirthDate;
            addStudent1.DpRegistrationDate.Value = s.RegistrationDate;
            addStudent1.RbFemale.Checked = s.Gender == "Male" ? false : true;
            addStudent1.RbMail.Checked = s.Gender == "Male" ? true : false;
            BtnAddStudent.Text = "Edit";
            btnAddStudentClicked();
            addStudent1.BtnAdd.Text = "Edit";
            addStudent1.BtnDelete.Visible = true;
            
        }
        public void Delete(int id)
        {
            Student obj = new Student();
            Student s = obj.List().Where(x => x.Id == id).FirstOrDefault();

            string message = "Do you want to Delete this Record?";
            string title = "Delete Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                obj.Delete(id);
                BindGrid();
                MessageBox.Show("Record Successfully Deleted");
            }
        }

        public void BindGrid()
        {
            String sort;
            try
            {
                sort = CmbSort.SelectedItem.ToString();

            }
            catch
            {
                sort = "";
            }
            Student obj = new Student();
            List<Student> listStudents = obj.List();
            if (sort == "Name")
            {
                List<Student> list = obj.SortByName(listStudents);
            }
            if (sort == "Registration Date")
            {
                List<Student> list = obj.SortByDate(listStudents);
            }
            DataTable dt = Utility.ConvertToDataTable(listStudents);
            home1.DGVStudentDetail.DataSource = dt;
            chart1.BindChart(listStudents);
            WeeklyReport(listStudents);
        }

        private void BtnChart_Click(object sender, EventArgs e)
        {
            CmbSort.Visible = false;
            BtnSort.Visible = false;
            SidePanel.Top = BtnChart.Top;
            SidePanel.Height = BtnChart.Height;
            this.chart1.BringToFront();
            this.home1.Visible = false;
            this.addStudent1.Visible = false;
            this.chart1.Visible = true;
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void WeeklyReport(List<Student> lst)
        {
            if (lst != null)
            {
                var result = lst
                    .GroupBy(d => new { V = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(d.RegistrationDate, CalendarWeekRule.FirstDay, DayOfWeek.Sunday), d.ProgramEnrolled })
                    .Select(c1 => new
                    {
                        Week = "Week" + c1.Key.V.ToString(),
                        Faculty = c1.First().ProgramEnrolled,
                        Total_Student = c1.Count().ToString(),

                    }).ToList();

                DataTable dt = Utility.ConvertToDataTable(result);
                report1.StudentReport.DataSource = dt;

            }
        }
            private void BtnReport_Click(object sender, EventArgs e)
        {
            CmbSort.Visible = false;
            BtnSort.Visible = false;
            SidePanel.Top = BtnReport.Top;
            SidePanel.Height = BtnReport.Height;
            this.report1.BringToFront();
            this.home1.Visible = false;
            this.addStudent1.Visible = false;
            this.chart1.Visible = false;
            this.report1.Visible = true;
        }

    }
}
