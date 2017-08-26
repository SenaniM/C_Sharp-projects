using System;
using System.Collections.Generic;
using System.Text;

namespace Robot
{
    class Robot
    {
        private int life, strenght;

        public int Strength {
            get
            {
                return strenght;
            }
            set
            {
                strenght = value;
            }
        }

        public int Life
        {
            get
            {
                return life;
            }
            set
            {
                life = value;
            }
        }
    }
}
