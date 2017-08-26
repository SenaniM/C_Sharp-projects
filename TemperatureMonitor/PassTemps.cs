using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureMonitor
{
    class PassTemps : EventArgs
    {
        public float diffTemp;

        public PassTemps(float diffTemp)
        {
            this.diffTemp = diffTemp;
        }

        public float DiffTemp
        {
            get
            {
                return diffTemp;
            }
        }

    }
}
