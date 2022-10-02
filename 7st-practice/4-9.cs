/*
9. Для каждой строки подсчитать количество элементов, больших заданного числа, и
записать данные в новый массив
*/

using System;
class HelloWorld {
  static void Main() {
    int n = int.Parse(Console.ReadLine());
    int k = int.Parse(Console.ReadLine());
    
    int[] ans = new int [n]; 
    var m = new int[n,n];
    
    for(int i = 0; i<n; i++){
        for(int j = 0; j<n; j++){
            m[i,j] = int.Parse(Console.ReadLine());
        }    
    }
    
    for(int i = 0; i<n; i++){
        int c = 0;
        for(int j = 0; j<n; j++){
            if(m[i,j] > k){
                c++;
            }
        }    
        ans[i] = c;
    }
    
    for(int i = 0; i<n; i++){
        Console.Write("{0}\n", ans[i]);    
    }
  }
}
