using System;

namespace TripleTroubleProgram
{
    public class Program
    {
        public static int z;
        public static int[] arrayOfTrippleNumbers = new int[9];
        public static int[] arrayOfDoubleNumbers = new int[9];
        public static int arrayPosition = -1;

        public static void Mai3n()
        {
            int isTt = TripleTrouble(1234445, 7654432);

            if (isTt == 1)
            {
                Console.WriteLine("Is Triple Trouple");
            }
            else
            {
                Console.WriteLine("Not Triple Trouble");
            }
        }

        public static int TripleTrouble(long num1, long num2)
        {
            int IsTrippleTrouble;

            checkForTripple(num1);
            checkForDouble(num2);

           string tripples = arrayOfTrippleNumbers.ToString();
           string doubles = arrayOfDoubleNumbers.ToString();

            if (tripples.Contains(doubles))
            {
                IsTrippleTrouble = 1;
            }
            else
            {
                IsTrippleTrouble = 0;
            }
            return IsTrippleTrouble;

        }

        public static void checkForTripple(long num1)
        {

            string firstNumberString = num1.ToString();

            for (int i = 0; i <= 9; i++)
            {
                string trippleNumber = ($"{i}{i}{i}");
                if (firstNumberString.Contains(trippleNumber)) // if NUMBER contains 000
                {
                    arrayOfTrippleNumbers[arrayPosition + 1] = i;
                }
            }
        }

        public static void checkForDouble(long num2)
        {
            string seccondNumberString = num2.ToString();

            for (int i = 0; i <= 9; i++)
            {
                string doubleNumber = ($"{i}{i}");
                if (seccondNumberString.Contains(doubleNumber)) // if NUMBER contains 00
                {
                    arrayOfDoubleNumbers[arrayPosition + 1] = i;
                }
            }
        }

    }
}