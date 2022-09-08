using System;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            int ans = 0;

            int d = 2;

            for (; n!=1; d++) {
                while (n % d == 0)
                {
                    ans += d * d;
                    n /= d;
                }   
            }

            Console.WriteLine("Ответ: {0}", ans);
                       
        }
    }

}
