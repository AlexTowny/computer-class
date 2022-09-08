using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.Write("{0}, ", i);
            }
            Console.WriteLine();
                       
        }
    }
}
