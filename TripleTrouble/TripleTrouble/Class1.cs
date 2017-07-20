using System.Collections.Generic;
using System.Linq;

namespace TripleTroubleProgram
{
    public class Class1
    {
        public static HashSet<int> tripleNumberHashSet = new HashSet<int>();
        public static HashSet<int> doubleNumberHashSet = new HashSet<int>();

        public static void Main()
        {
            var isTrippleTrouble = TripleDouble(1234445, 1364492);
            if (isTrippleTrouble == 1)
            {
                System.Console.WriteLine("Is TT");
            }
            else if (isTrippleTrouble == 0)
            {
                System.Console.WriteLine("Isnt TT");
            }
            else
            {
                System.Console.WriteLine("something went wrong");
            }

            System.Console.ReadLine();
        }

        public static int TripleDouble(long num1, long num2)
        {
            int IsTrippleTrouble;

            CheckForTripple(num1);
            CheckForDouble(num2);

            var x = doubleNumberHashSet;
            var y = tripleNumberHashSet;

            tripleNumberHashSet.IntersectWith(doubleNumberHashSet);


            if (tripleNumberHashSet.Count == 1)
            {
                IsTrippleTrouble = 1;
            }
            else
            {
                IsTrippleTrouble = 0;
            }
            return IsTrippleTrouble;

        }

        public static void CheckForTripple(long num1)
        {

            string firstNumberString = num1.ToString();

            for (int i = 0; i <= 9; i++)
            {
                string trippleNumber = ($"{i}{i}{i}");
                if (firstNumberString.Contains(trippleNumber)) // if NUMBER contains XXX
                {
                    tripleNumberHashSet.Add(i);
                }
            }
        }

        public static void CheckForDouble(long num2)
        {
            string seccondNumberString = num2.ToString();

            for (int i = 0; i <= 9; i++)
            {
                string doubleNumber = ($"{i}{i}");
                if (seccondNumberString.Contains(doubleNumber)) // if NUMBER contains XX
                {
                    doubleNumberHashSet.Add(i);
                }
            }
        }

    }
}