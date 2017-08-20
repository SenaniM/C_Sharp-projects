using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Employee
{
    public partial class EmpDetails : Form

    {
        private String hairColor;
        private List<Employee> emps;      

        public EmpDetails()
        {

            var color = new BindingList<KeyValuePair<string, string>>();
            color.Add(new KeyValuePair<string, string>("Black", "Black"));
            color.Add(new KeyValuePair<string, string>("Brown", "Brown"));
            color.Add(new KeyValuePair<string, string>("White", "White"));

            InitializeComponent();
            emps = new List<Employee>();

            cmbHair.DataSource = color;
            cmbHair.ValueMember = "Key";
            cmbHair.DisplayMember = "Value";

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
                lblHouseClr.Text = clr.Name;
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
            emp.HouseColor = lblHouseClr.Text;
            hairColor = cmbHair.SelectedValue.ToString();
            emp.HairColor = hairColor;
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

        private void EmpDetails_Load(object sender, EventArgs e)
        {
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFormFields(this);
        }

        private void clearFormFields(Control controls)
        {
            foreach (Control c in controls.Controls) 
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else if (c is RadioButton)
                    ((RadioButton)c).Checked = false;
                else if (c is ComboBox)
                    ((ComboBox)c).SelectedIndex = -1;
                else if (c is CheckBox)
                    ((CheckBox)c).Checked = false;

                if (c.HasChildren)
                    clearFormFields(c);
            }
        }
    }
}