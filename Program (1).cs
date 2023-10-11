using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1)*/
            /* Console.Write("Bir eded daxil edin: ");
            int eded = Convert.ToInt32(Console.ReadLine());
            bool Issade = true;
            for (int i = 2; i < eded; i++)
            {
                if (eded % i == 0)
                {
                    Issade = false;
                }
            }
            if (Issade)
            {
                Console.WriteLine("Sadedir");
            }
            else
            {
                Console.WriteLine("Murekkebdir");
            }*/
            /*2)*/
            /*Console.WriteLine("Eded Daxil Edin: ");
            int eded = Convert.ToInt32(Console.ReadLine());
            for (; eded % 2 == 0 && eded > 0;)
            {
                eded /= 2;
            }
            if (eded == 1) {
                Console.WriteLine("True");
            }else{
                Console.WriteLine("False");
            }*/
            /*3)*/
            /*Console.Write("Bir eded daxil edin: ");
            int eded = Convert.ToInt32(Console.ReadLine());

            int mertebeler = 0;

            for(; eded!=0; eded /= 10)
            {
                mertebeler++;
            }
            Console.WriteLine(mertebeler);*/
        }
    }
}