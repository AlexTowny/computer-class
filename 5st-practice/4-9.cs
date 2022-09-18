
using System;
class HelloWorld {
 
  
  static void R(int N, int D=2){
        
        
        if( N%D == 0 ){
            Console.Write("{0} ", D);
            R(N/D, D);
        }
        else if(N!=1){
            R(N, D+1);
        }
        
        
  }
    
  static void Main() {
    int A = int.Parse(Console.ReadLine());
    int B = int.Parse(Console.ReadLine());
    
    for(int i = A; i<=B; i++){
        R(i);
        Console.Write("\n");
    }
  }
}
/*
2
10
2 
3 
2 2 
5 
2 3 
7 
2 2 2 
3 3 
2 5
-----
5
5
5
-----
1234
1236
2 617 
5 13 19 
2 2 3 103 
*/
