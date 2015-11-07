using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaprekar
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();
            int[] highestValue = new int[4];
            int[] lowestValue = new int[4];
            string hVal = "";
            string lVal = "";
            int count = 1;
            while (inputNumber != "6174")
            {
                for (int c = 0; c < inputNumber.Length; c++)
                {
                    highestValue[c] = ((int)inputNumber[c] - 48);
                    lowestValue[c] = ((int)inputNumber[c] - 48);
                }
                inputNumber = "";
                for (int i = 0; i < lowestValue.Length; i++)
                {
                    for (int j = 0; j < (lowestValue.Length - 1); j++)
                    {
                        if (lowestValue[j] > lowestValue[i])
                        {
                            int holding = lowestValue[j];
                            lowestValue[j] = lowestValue[i];
                            lowestValue[i] = holding;
                        }
                    }
                }
                for (int i = 0; i < highestValue.Length; i++)
                {
                    for (int j = 0; j < (highestValue.Length - 1); j++)
                    {
                        if (highestValue[j] < highestValue[i])
                        {
                            int holding = highestValue[j];
                            highestValue[j] = highestValue[i];
                            highestValue[i] = holding;
                        }
                    }
                }
                Console.Write("Lowest: ");
                for (int i = 0; i < lowestValue.Length; i++)
                {
                    Console.Write(lowestValue[i].ToString());
                }
                Console.WriteLine();
                Console.Write("Highest: ");
                for (int i = 0; i < highestValue.Length; i++)
                {
                    Console.Write(highestValue[i].ToString());
                }
                for (int i = 0; i < lowestValue.Length; i++)
                {
                    lVal = lVal + lowestValue[i].ToString();
                }
                for (int i = 0; i < highestValue.Length; i++)
                {
                    hVal = hVal + highestValue[i].ToString();
                }
                inputNumber = (Int32.Parse(hVal) - Int32.Parse(lVal)).ToString();
                Console.WriteLine();
                Console.WriteLine("The next value is: " + inputNumber);
                hVal = "";
                lVal = "";
                count++;
            }
            Console.WriteLine("Kaprekar's number found in " + count + " iterations");
            Console.ReadLine();
        }
    }
}
