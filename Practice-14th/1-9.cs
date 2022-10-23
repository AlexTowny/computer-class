/*
I. Решить задачу, используя структуру SPoint для хранения координат точки:
9–10. Найти такую точку, что шар радиуса R с центром в этой точке содержит максимальное
число точек заданного множества.
*/

using System;
class HelloWorld {
    struct SPoint //описание структуры
    {
    public int x, y, z; //поля структуры
    public SPoint (int x, int y, int z) //конструктор структуры
        {
            this.x=x;
            this.y=y;
            this.z=z;
        }
    //методы структуры  
    public void Show()
        {
            Console.WriteLine("({0}, {1})",x, y);
        }
    public double DistanceTo(SPoint b)
        {
            return Math.Sqrt(Math.Pow(this.x-b.x,2)+
                             Math.Pow(this.y-b.y,2)+
                             Math.Pow(this.z-b.z,2));
        }
    }
    
  static void Main() {
      double R;
      int n;
      R = double.Parse(Console.ReadLine());
      n = int.Parse(Console.ReadLine());
      
      SPoint[] m = new SPoint[n];
      
      for(int i = 0; i<n; i++){
        m[i] = new SPoint(int.Parse(Console.ReadLine()), 
                          int.Parse(Console.ReadLine()), 
                          int.Parse(Console.ReadLine()));
      }
      
      SPoint best = new SPoint(0,0,0);
      int max_c = 0;
      
      for(int i = 0; i<n; i++){
        int c = 0;
        for(int j = 0; j<n; j++){
            if(i!=j){
                if(m[i].DistanceTo(m[j]) < R){
                    ++c;
                }
            }
        }
        
        if(c>max_c){
            max_c = c;
            best = m[i];
        }
      }
      
    if(max_c!=0){
      best.Show();
    }
    else{
      Console.WriteLine("That point not exist.");
    }
    
      
  }
}
