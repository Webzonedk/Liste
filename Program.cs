using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> straightNumbers = new List<int>();
            List<int> straightNumbersReversed = new List<int>();

            int numberCount = 20;

            straightNumbers = Calc.AddNumbers(numberCount, straightNumbers);

            for (int i = 0; i < straightNumbers.Count; i++)
            {
                Console.WriteLine(straightNumbers[i]);
            }


            straightNumbers = Calc.RemoveThrees(straightNumbers);
            Console.WriteLine("numre minus 3");
            for (int i = 0; i < straightNumbers.Count; i++)
            {
                Console.WriteLine(straightNumbers[i]);
            }


            int seventeen = 17;
            straightNumbers = Calc.Add17(seventeen, straightNumbers);
            Console.WriteLine("Nummer 17 tilføjet på plads 3");
            for (int i = 0; i < straightNumbers.Count; i++)
            {
                Console.WriteLine(straightNumbers[i]);
            }




            straightNumbersReversed = Calc.ReverseList(straightNumbers, straightNumbersReversed);
            Console.WriteLine("Nu er listen vendt om");
            for (int i = 0; i < straightNumbersReversed.Count; i++)
            {
                Console.WriteLine(straightNumbersReversed[i]);
            }




            Console.ReadLine();
        }
    }
}
