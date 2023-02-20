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
        public static string GetVINCountry(string vin)
        {
            if (CheckVIN(vin))
            {
                if(vin[0] == 'A' || vin[0] == 'B' || vin[0] == 'C' )
                {
                    return "Африка";
                }
                if (vin[0] == 'J' || vin[0] == 'K' || vin[0] == 'R' )
                {
                    return "Азия";
                }
                if (vin[0] == 'S' || vin[0] == 'U' || vin[0] == 'Z')
                {
                    return "Европа";
                }
                if (vin[0] == '1' || vin[0] == '2' || vin[0] == '3')
                {
                    return "Северная Америка";
                }
                if (vin[0] == '6' || vin[0] == '7')
                {
                    return "Океания";
                }
                else
                {
                    return "Южная Америка";
                }
            }
            else
            {
                return null;
            }
        }

    }
}
