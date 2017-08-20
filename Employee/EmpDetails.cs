using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class EmpDetails : Form

    {
        private string[] hairColor;
        private List<Employee> emps;

        public EmpDetails()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblHouseClr_Click(object sender, EventArgs e)
        {
            DialogResult res = this.clrDialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                Color clr = clrDialog.Color;
                lblHouseClr.BackColor = clr;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Name = textName.Text;
            emp.Dob = dtpDob.Text;
            emp.Gender = 'M';

            if (rdbGender.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked) == rdbMale)
            {
                emp.Gender = 'M';
            }
            emp.IsSmoking = chkSmoke.Checked;
            // emp.HouseColor = (lblHouseClr).GetContainerControl;
            emp.HairColor = cmbHair.Text;
            emps.Add(emp);
            MessageBox.Show("Save complete !");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveAsCsv();
        }

        public void saveAsCsv()
        {
            FileDialog fd = new SaveFileDialog();
            DialogResult dialrs = fd.ShowDialog();

            if (dialrs == DialogResult.OK)
            {
                using (System.IO.StreamWriter sr = new System.IO.StreamWriter(fd.FileName, true))
                {
                    foreach (Employee emp in emps)
                    {
                        sr.WriteLine(emp.ToString());
                    }
                }
            }
        }
    }
}