
using System;
class HelloWorld {
  static void Main() {
    string fword = Console.ReadLine();
    string text = Console.ReadLine();
    string[] words = text.Split(' ', '.', ',', '!', '?');
    
    int c = 0;
    
    foreach(string word in words){
        if(word == fword){
            c++;   
        }
    }
    
    Console.WriteLine("Answer: {0}", c);
  }
}
