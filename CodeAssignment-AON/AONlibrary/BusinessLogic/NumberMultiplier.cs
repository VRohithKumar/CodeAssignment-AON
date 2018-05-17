using System;
using System.Collections.Generic;
using System.Text;

namespace AONLibrary.BusinessLogic
{
    /// <summary>
    /// Purpose is to handle all operations that are necessory for multiple operations
    /// </summary>
   public static class NumberMultiplier
    {
        /// <summary>
        /// Returns true for multiples of three
        /// </summary>
        /// <param name="number"></param>
        /// <returns>true/false</returns>
        static bool IsMultipleOfThree(int number)
        {
            return number % 3 == 0 ? true : false;

        }
        /// <summary>
        /// Returns true for multiples of five
        /// </summary>
        /// <param name="number"></param>
        /// <returns>true/false</returns>

        static bool IsMultipleOfFive(int number)
        {
            return number % 5 == 0 ? true : false;
        }
        /// <summary>
        /// Returns true for multiples of five and three
        /// </summary>
        /// <param name="number"></param>
        /// <returns>true/false</returns>
        static bool IsMultipleOfThreeAndFive(int number)
        {
            return ((number % 3 == 0) && (number % 5 == 0)) ? true : false;
        }
        /// <summary>
        /// returns result by validating appropriate multiples
        /// </summary>
        /// <param name="number"></param>
        /// <returns>one of the BubbleBobble/Bubble/Bobble/number</returns>
        public static string GetResultForNumber(int number)
        {
            return IsMultipleOfThreeAndFive(number) ? "BubbleBobble " + number : IsMultipleOfThree(number) ? "Bubble "  : IsMultipleOfFive(number) ? "Bobble "  : number.ToString();
           
        }


    }
}
