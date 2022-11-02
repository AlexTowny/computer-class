/*
I. Дана последовательность целых чисел
Вывести на экран все двухзначные числа, увеличив их на 5.
*/

using System;
using System.Linq;

class HelloWorld {
  static void Main() {
      int n = int.Parse(Console.ReadLine());
      int[] m = new int[n];
      
      for(int i = 0; i<n; i++){
          m[i] = int.Parse(Console.ReadLine());
      }
      
      var k = from p in m
              where p < 100 && p>9
              select p+5;

      
      foreach(var i in k){
          Console.Write("{0} ",i);
      }
  }
}
