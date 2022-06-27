// See https://aka.ms/new-console-template for more information
using System;
namespace PrimeNO
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cheking for Prime Number");
            char ans='Y';
            while (ans == 'Y'|| ans == 'y'){
                int m=0, flag = 0;
                Console.WriteLine("Enter a number");
                int n = Convert.ToInt32(Console.ReadLine());
                m = n / 2;
                for (int i = 2; i < m; i++)
                {
                    if (n % i == 0)
                    {
                        flag = 1;
                        Console.WriteLine("Not prime");
                        break;
                    }
                }
                if (flag == 0)
                    Console.WriteLine("Prime");

                Console.WriteLine("DO u want to Continue (Y/N)");
                ans = Console.ReadLine()[0];
            } }
    }
}
