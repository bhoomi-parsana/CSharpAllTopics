using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session9_PropetiesAndIndexer
{
    internal class ATMPin
    {
        private string _pin;
        public string Pin
        {
            get { return _pin; }
            set
            {

                if (value != null && value != "")
                {
                    if (value.Length == 4 || value.Length == 6)
                    {
                        bool isValid = true;   
                        for (int i = 0; i < value.Length; i++)
                        {
                            if (value[i] < 48 || value[i] > 57)
                            {
                                isValid = false;
                            }
                        }
                        if (isValid)
                        {
                            _pin = value;
                        } else
                        {
                            System.Console.WriteLine("PIN contains one or more non-digit characters.");
                        }
                    }
                    else System.Console.WriteLine("PIN should contain either 4 digits or 6 digits");


                } else 
                System.Console.WriteLine("PIN value can't be blank");

            }
        }
    }
}
