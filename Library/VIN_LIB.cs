using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Library
{
    public  class VIN_LIB
    {
        public static bool CheckVIN(string vin)
        {
            Regex regex = new Regex("^[A-HJ-NRT-Z0-9]{17}$"); // регулярное выражение 
            bool a = regex.IsMatch(vin);
            if(!a)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //public string GetVINCountry(string vin)
        //{
        //    string countre;
        //    return countre;
        //}

    }
}
