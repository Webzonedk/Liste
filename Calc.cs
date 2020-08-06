using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste
{
    class Calc
    {
        public static List<int> AddNumbers(int amount, List<int> tempList)
        {
            for (int i = 0 + 1; i < amount + 1; i++)
            {
                if (i % 2 == 0)
                {

                    tempList.Add(i);
                }
            }
            return tempList;
        }

        public static List<int> RemoveThrees(List<int> tempList)
        {
            for (int i = 0; i < tempList.Count; i++)
            {
                if (tempList[i] % 3 == 0)
                {

                    tempList.RemoveAt(i);

                }
            }
            return tempList;
        }

        public static List<int> Add17(int seventeen, List<int> tempList)
        {
            for (int i = 0; i < tempList.Count; i++)
            {
                if (i == 2)
                {

                    tempList.Insert(i, seventeen);

                }
            }
            return tempList;
        }


        public static List<int> ReverseList(List<int> tempList, List<int> tempListNew)
        {
            for (int i = 0; i < tempList.Count; i++)
            {
                int temp = tempList[i];
                    tempListNew.Add(temp);

            }
            tempListNew.Reverse();
            return tempListNew;
        }
    }
}
