
using System;

class HelloWorld {
  static int GCD(int a, int b){
    
    if(a>b){
        return GCD(a-b, b);
    }
    else if(b>a){
        return GCD(a, b-a);
    }
    else{
        return a;
    }
  }
  
  
  
  static void Main() {
    //a
    //2 4 = 2
    //22 33 = 11
    // 1 1 = 1
    
    Console.Write("Сокращение дроби вида a/b\nВведите a:");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Введите b:");
    int b = int.Parse(Console.ReadLine());
    Console.Write("Результат: {0}/{1}\n", a/GCD(a,b), b/GCD(a,b));
     
    //b
    //270 315 = 1890
    //2 4 = 4
    //33 2 = 66
    
    Console.Write("НОК для a,b\nВведите a:");
    a = int.Parse(Console.ReadLine());
    Console.Write("Введите b:");
    b = int.Parse(Console.ReadLine());
    Console.Write("Результат: {0}\n", a*b/GCD(a,b));
    
    //c
    // 3 2 4 5 = 11/4
    // 4 5 3 2 = 22/15
    // 1 1 1 1 = 2/1
    Console.Write("Выражение a/b + d/c\nВведите a:");
    a = int.Parse(Console.ReadLine());
    Console.Write("Введите b:");
    b = int.Parse(Console.ReadLine());
    Console.Write("Введите c:");
    int c = int.Parse(Console.ReadLine());
    Console.Write("Введите d:");
    int d = int.Parse(Console.ReadLine());
    
    int chisl = a*c + d*b;
    int znam = b*c;
    
    Console.Write("Результат: {0}/{1}\n", chisl/GCD(chisl,znam), znam/GCD(chisl,znam));
    
    //d
    // 5 22 32 16 4 = 2
    // 33 22 77 44 = 11
    // 72 27 81 18 = 9
    Console.Write("НОД для n натуральных чисел\nВведите n:");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите числа:\n");
    
    int ans = int.Parse(Console.ReadLine());
    for(int i = 1; i < n; i++){
        int k = int.Parse(Console.ReadLine());
        ans = GCD(ans, k);
    }
    
    Console.Write("Результат: {0}\n", ans);
  
      
  }
}
