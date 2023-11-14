using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC_KIMLIK
{
    internal class PEersonel
    {
        private string tckimlikno;

        public string TCKimliKNO
        {
            get
            {
                if(tckimlikno.Length  >= 5)
                {
                    return tckimlikno.Substring(0, 5);
                }
                else
                {
                    return tckimlikno;
                }
            }
            set
            {
                if(value.Length == 11)
                {
                    if (IsNumeric(value))
                    {
                        tckimlikno = value;
                    }
                    else
                    {
                        Console.WriteLine("HATA : TC Kimlik no sayısal olmalı:");
                    }
                    
                }
                else
                {
                    Console.WriteLine("HATA : TC Kimlik no 11 haneli olmalıdır.");
                }
                
            }
        }
        private bool IsNumeric(string value)
        {
            foreach(char c in value)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
