using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStartedDebugging
{
    internal class Program
    {
        static void Main()
        {
            int[] Z = new int[35];
            Random rand = new Random();
            int S = 0, P = 1, R = 0;
            Console.WriteLine("Массив целых чисел:");
            for(int i = 0; i<Z.Length; i++)
            {
                Z[i] = rand.Next(-10,10);
                SendMessage(Z[i]);
            }
            for (int y = 0; y < Z.Length; y++)
            {
                if (Z[y]%2 == 0 && Z[y] <3)
                {
                    S += Z[y];
                }
                if (Z[y] % 2 != 0 && Z[y] > 1)
                {
                    P *= Z[y];
                }
            }
            Console.WriteLine();
            R = P + S;
            SendMessage2(S, P, R);
            Console.ReadKey();
        }
        static void SendMessage(int a)
        {
            Console.Write(a + " ");
        }
        static void SendMessage2(int S, int P, int R)
        {
            Console.WriteLine("Сумма чётных чисел, меньше 3: S = " + S);
            Console.WriteLine("Сумма нечётных чисел, больше 1: P = " + P);
            Console.WriteLine("R = " + R);
        }
    }
}
