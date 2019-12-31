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
    public partial class Home : UserControl
    {
        public StudentForm MainForm { get; set; }
        public Home(){
            InitializeComponent();
        }
      
        private void CellDoubleClickAction(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = int.Parse(DGVStudentDetail[0, e.RowIndex].Value.ToString());
                this.MainForm.Edit(id);

            }
            catch
            {
                MessageBox.Show("Empty Table Selected");
            }
                    }


    }
}
