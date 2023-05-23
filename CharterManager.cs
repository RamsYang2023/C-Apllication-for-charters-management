/*
 * Project:         Assignment Set 7 - Program 16
 * Date:            November 5 2022
 * Developed By:    Gsmh Yang
 * Class Name:      Charter manager
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GYangProgram16
{
    class CharterManager
    {
        #region "Property"

        // Delcare assessor for object of List<Charter>
        public List<Charter> CharterList { get; private set; }

        #endregion

        #region "Constructor"

        // instantiate a CharterManager object and the CharterList collection

        public CharterManager()
        {
            CharterList = new List<Charter>();
        }

        #endregion

        #region "Method"

        // A method to instantiate a Charter object and add it to the List<Charter> collection
        public void AddCharter(String cutomerName, string yachtType, int yachtSize, decimal charterHours)
        {
            Charter aCharter = new Charter(cutomerName, yachtType, yachtSize, charterHours);

            //add aCharter object into the List<Charter> collection.
            CharterList.Add(aCharter); 

        }

        //Get the counts for a specific yachet size.

        public int GetCharterCount(int yathtSize)
        {
            // using LINQ (Method Syntax)
            int counts = CharterList.Count(f => f.YachtSize == yathtSize);
            return counts;
        }

        // Get the total charter rental fees.
        public decimal GetTotalCharterFees()
        {
            // using LINQ (Method Syntax)

            Decimal total = CharterList.Sum(f => f.CharterFee);
            return total;

            //decimal total = 0;

            //foreach (Charter aCharter in CharterList)
            //{
            //    total += aCharter.CharterFee;
            //}

            //return total;

        }

        //Method to get average charter fee
        public decimal GetAverageCharterFee()
        {
            // using LINQ (Method Syntax)
            decimal average = CharterList.Average(f => f.CharterFee);
            return average;

        }

        //Method to fnd lowest charter fee.
       public decimal FindLowestCharterFee()
        {
            // using LINQ (Method Syntax)

            var lowest = CharterList.Min(f => f.CharterFee);

            return lowest;

            //decimal currentLowest = CharterList[0].CharterFee;

            //foreach (Charter aCharter in CharterList)
            //{
            //    if (aCharter.CharterFee < currentLowest)
            //    {
            //        currentLowest = aCharter.CharterFee;
            //    }

            //}
            //return currentLowest;
        }
        #endregion
    }
}
