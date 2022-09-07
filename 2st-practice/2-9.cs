using System;
class Math {
  static void Main() {
    
    Console.Write("Введите число = ");
    int k = int.Parse(Console.ReadLine());
    
    Console.Write((( k % 10 * (k/10%10) ) % 2 == 0)?"Да":"Нет");
    
  }
}
