using System;
class Bank {
  static void Main() {
    
    Console.Write("Введите сумму вклада = ");
    double sum = double.Parse(Console.ReadLine());
    
    Console.Write("Введите процент по вкладу = ");
    double percent = double.Parse(Console.ReadLine());
    
    double depos = sum * ( 1 + percent/100 ); 
    
    Console.Write("Через год сумма на вкладе = {0:C}", depos);
    
  }
}
