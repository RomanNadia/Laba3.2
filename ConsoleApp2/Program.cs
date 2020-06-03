using System;

namespace ConsoleApp2
{
    using System;
    using System.IO;

    namespace OOP_lab_3_18_2
    {
        class Program
        {
            static void Main(string[] args)
            {
                StreamReader file = new StreamReader("file.txt");

                string[] numbers = file.ReadToEnd().Split(new char[] { '\r', '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int[] a = new int[numbers.Length];

                for (int i = 0; i < numbers.Length; ++i)
                {
                    a[i] = int.Parse(numbers[i]);
                }

                int k = 0;

                for (int i = 0; i < numbers.Length; ++i)
                {
                    if (a[i] % 2 != 0)
                    {
                        ++k;
                    }
                }

                Console.WriteLine("Number of odd numbers: {0}", k);

                if (k != 0)
                {
                    Console.Write("Odd numbers:");

                    for (int i = 0; i < numbers.Length; ++i)
                    {
                        if (a[i] % 2 != 0)
                        {
                            Console.Write(" {0}", a[i]);
                        }
                    }
                }
            }
        }
    }
}
