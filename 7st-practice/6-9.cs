/*
9. Удалить все столбцы, в которых четное количество нечетных элементов
*/

using System;
class HelloWorld {
    
    static void del_col(ref int[][] m, ref int n, ref int n2, int col){
        
        for(int i = 0; i<n; i++){
            int[] h = new int[n2-1];
            int id = 0;
            for(int j = 0; j<n2; j++){
                if(j!=col){
                    h[id++] = m[i][j];
                }
            }
            
            m[i] = h;
        }   
        --n2;
        
    }

  static void Main() {
    int n = int.Parse(Console.ReadLine());
    int n2 = n;
    int[][] m = new int[n][];
    for(int i = 0; i<n; i++){
        m[i] = new int[n];
    }
    
    for(int i = 0; i<n; i++){
        for(int j = 0; j<n; j++){
            m[i][j] = int.Parse(Console.ReadLine());
        }    
    }
    
    for(int i = 0; i<n2; i++){
        int c = 0;
        for(int j = 0; j<n; j++){
            if(m[j][i]%2!=0){
                ++c;
            } 
        }
        if(c%2==0 && c>0){
            del_col(ref m, ref n, ref n2, i);
        }
    }
    
    for(int i = 0; i<n; i++){
        for(int j = 0; j<n2; j++){
            Console.Write("{0} ", m[i][j]);
        }    
        Console.Write("\n");
    }
  }
}
