using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employee
    {
        private String name, dob, houseColor, hairColor;
        private char gender;
        private bool isSmoking;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Dob
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
        }

        public char Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public bool IsSmoking
        {
            get
            {
                return isSmoking;
            }
            set
            {
                isSmoking = value; 
            }
        }

        public string HouseColor
        {
            get
            {
                return houseColor;
            }
            set
            {
                houseColor = value;
            }
        }

        public string HairColor
        {
            get
            {
                return hairColor;
            }
            set
            {
                hairColor = value;
            }
        }
    }
}
