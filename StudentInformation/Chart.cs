using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation
{
    public partial class Chart : UserControl
    {
        public Chart()
        {
            InitializeComponent();
        }
        public void BindChart(List<Student> lst)
        {
           

            if (lst != null)
            {
                var result2 = lst
                    .GroupBy(l => l.ProgramEnrolled)
                    .Select(c2 => new
                    {
                        enrolled = c2.First().ProgramEnrolled,
                        Count = c2.Count().ToString()
                    }).ToList();


                DataTable dt1 = Utility.ConvertToDataTable(result2);

                ProgramEnrolled.DataSource = dt1;
                ProgramEnrolled.Name = "Gender";
                ProgramEnrolled.Series["Series1"].XValueMember = "enrolled";
                ProgramEnrolled.Series["Series1"].YValueMembers = "Count";
                this.ProgramEnrolled.Titles.Remove(this.ProgramEnrolled.Titles.FirstOrDefault());
                this.ProgramEnrolled.Titles.Add("Program Enrolled ");
                ProgramEnrolled.Series["Series1"].IsValueShownAsLabel = true;

                var result = lst
                    .GroupBy(l => l.Gender)
                    .Select(cl => new
                    {
                        Gender = cl.First().Gender,
                        Count = cl.Count().ToString()
                    }).ToList();
                DataTable dt = Utility.ConvertToDataTable(result);

                studentChart.DataSource = dt;
                studentChart.Name = "Gender";
                studentChart.Series["Series1"].XValueMember = "Gender";
                studentChart.Series["Series1"].YValueMembers = "Count";
                this.studentChart.Titles.Remove(this.studentChart.Titles.FirstOrDefault());
                this.studentChart.Titles.Add("Gender Chart");
                studentChart.Series["Series1"].IsValueShownAsLabel = true;



                

            }
        }
        public DataTable DataSource { get; internal set; }
    }
}
