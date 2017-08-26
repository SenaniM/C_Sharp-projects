using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureMonitor
{
    public partial class formTemp : Form
    {
        private Calculate tempCalc;

        public formTemp(float initTemp)
        {
            InitializeComponent();
            this.tempCalc = new Calculate(initTemp);
            this.lblTemp.Text = this.tempCalc.Temp.ToString();

            this.btnSunny.Click += new EventHandler(changeTemp);
            this.btnRainy.Click += new EventHandler(changeTemp);
            this.btnAdhoc.Click += new EventHandler(changeTemp);
            this.tempCalc.ChangeEventTemp += new Calculate.TriggerChange(showMessage);
        }

        private void showMessage(object sender, PassTemps t)
        {
            MessageBox.Show("Temperature changed");
        }

        private void changeTemp(object sender, EventArgs e)
        {
            float deltaT = 0.0f;
            switch (((Button)sender).Name)
            {
                case "btnSunny":
                    deltaT = 10.0f;
                    break;

                case "btnRainy":
                    deltaT = -10.0f;
                    break;

                case "btnAdhoc":
                    Random r = new Random();
                    deltaT = (float)(-5.0 + r.NextDouble() * 10);
                    break;
            }
            float t = tempCalc.calTemp(deltaT);
            lblTemp.Text = t.ToString();

        }
    }
}
