using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureMonitor
{
    class Calculate
    {
        public float temperature;

        public Calculate(float temp)
        {
            this.temperature = temp;
        }

        public float Temp
        {
            get
            {
                return temperature;
            }
        }

        public float calTemp(float difTemp)
        {
            this.temperature = temperature + difTemp;
            PassTemps ptemps = new PassTemps(difTemp);
            ChangeEventTemp(this, ptemps);
            return this.temperature;
        }

        public event TriggerChange ChangeEventTemp;
        public delegate void TriggerChange(object sender, PassTemps t);
    }
}
