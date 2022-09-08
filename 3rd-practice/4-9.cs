using System;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите число A = ");
            int A = int.Parse(Console.ReadLine());
            
            Console.Write("Введите число B = ");
            int B = int.Parse(Console.ReadLine());

            for (int i = A; i <= B; i++) {
                if (i % 3 == 0)
                { 
                    Console.Write("{0}, ", i); 
                }
            }
            Console.WriteLine();
                       
        }
    }

}
