/*
 * Project:         Assignment Set 7 - Program 16
 * Date:            November 5 2022
 * Developed By:    Gsmh Yang
 * Class Name:      Charter manager
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace GYangProgram16
{
    class Charter
    {
        #region "Auto-implemented Properties"

        // declare properties.
        public string customerName { get; private set; }
        public string YachtType { get; private set; }
        public int YachtSize { get; private set; }
        public decimal CharterFee { get; private set; }
        public decimal CharterHours { get; private set; }

        #endregion

        #region "Constructors"
        //Define the Constructor

        public Charter(string name, string type, int size, decimal hours)
        {
            //instantiate object
            customerName = name;
            YachtType = type;
            YachtSize = size;
            CharterHours = hours;

            //invoke the private method to calculate charter rent fee.
            CharterFee = CalculateCharterFee();
        }
        #endregion

        #region "method"

        //The method to calculate charter rental fee.
        private decimal CalculateCharterFee()
        {
            // constants and Variables
            const int hourRatefor22 = 235;
            const int hourRatefor24 = 301;
            const int hourRatefor30 = 355;
            const int hourRatefor32 = 417;
            const int hourRatefor36 = 563;
            const int hourRatefor38 = 599;
            const int hourRatefor45 = 697;

            decimal rentFee = 0;

            //Switch condition to calculate the rental fee.
            switch (YachtSize)
            {
                case 22:
                    rentFee = CharterHours * hourRatefor22;
                    break;
                case 24:
                    rentFee = CharterHours * hourRatefor24;
                    break;
                case 30:
                    rentFee = CharterHours * hourRatefor30;
                    break;
                case 32:
                    rentFee = CharterHours * hourRatefor32;
                    break;
                case 36:
                    rentFee = CharterHours * hourRatefor36;
                    break;
                case 38:
                    rentFee = CharterHours * hourRatefor38;
                    break;
                case 45:
                    rentFee = CharterHours * hourRatefor45;
                    break;
            }

             return rentFee;
        }

        #endregion
    }
}
