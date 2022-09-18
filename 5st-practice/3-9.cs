
using System;
class HelloWorld {
 
  static double F(int N){
      return ((double)N)/R(N);
  }    
    
  static double R(int N, int K = 1){
        if (K<N)
            return Math.Sqrt(((double)K)+R(N,K+1));
        else
            return Math.Sqrt(K);
  }
    
  static void Main() {
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine("{0}", F(n));
  }
}
