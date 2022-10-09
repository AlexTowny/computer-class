/*
9. Удалить все столбцы, в которых четное количество нечетных элементов
*/



using System;
class HelloWorld
{

    static void del_col( int[][] m, int col, int n)
    {

        for (int i = col; i < n-1; i++)
        {
            m[i] = m[i + 1];
        }
       m[n-1] = null;

    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = n;
        
        int[][] m = new int[n][];


        for (int i = 0; i < m.Length; i++)
        {
            m[i] = new int[n];
        }

        for (int i = 0; i < m.Length; i++)
        {
            for (int j = 0; j < m[i].Length; j++)
            {
                m[j][i] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < n; i++)
        {
            int c = 0;
            
            for (int j = 0; j < p; j++)
            {
                if (m[i][j] % 2 != 0)
                {
                    ++c;
                }
            }
            if (c % 2 == 0 && c > 0)
            {
                del_col( m, i--, n);
                --n;
            }
        }

        for (int i = 0; i < p; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0} ", m[j][i]);
            }
            Console.Write("\n");
        }
    }
}
