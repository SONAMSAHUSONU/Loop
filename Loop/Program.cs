using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {

                 
                int n;
                int status = 1;
                int num = 3;
                Console.WriteLine("First 100 prime numbers are:");
                Console.WriteLine(2);
                for (int i = 2; i <= 100;)
                {
                    for (int j = 2; j <= num; j++)
                    {
                        if (num % j == 0)
                        {
                            status = 0;
                            break;
                        }
                    }
                    if (status != 0)
                    {
                        Console.WriteLine(num);
                        i++;
                    }
                    status = 1;
                    num++;
                }
            }
        }

    }
    

