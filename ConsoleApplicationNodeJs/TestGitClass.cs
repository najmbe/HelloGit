using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationNodeJs
{
    public class TestGitClass
    {
        private static void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            //^ Exclusive disjunction or exclusive or is a logical operation that outputs true only when both inputs differ (one is true, the other is false).
            //x ^= y – XOR assignment. XOR the value of y with the value of x, store the result in x, and return the new value.

            a ^= b;
            b ^= a;
            a ^= b;
        }

        public static void GetPer(char[] list)
        {
            int x = list.Length - 1;
            GetPer(list, 0, x);
        }

        private static void GetPer(char[] list, int k, int m)
        {
            if (k == m)
            {
                Console.Write(list);
                Console.Write("\n");
            }
            else
                for (int i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    GetPer(list, k + 1, m);
                    Swap(ref list[k], ref list[i]);
                }
        }
    }
}
