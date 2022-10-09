
using System;
using System.IO;
class HelloWorld {
  
  static void Main() {
    
     using( StreamReader file1 = new StreamReader("1.txt")){
         using(StreamReader file2 = new StreamReader("2.txt")){
            using(StreamWriter ans = new StreamWriter("ans.txt")){
                string src1 = file1.ReadToEnd();
                string src2 = file2.ReadToEnd();
                
                string[] numbers1 = src1.Split(' ');
                string[] numbers2 = src2.Split(' ');
                
                for(int i = 0; i<numbers1.Length; i++){
                    if(i%2==0){
                        ans.Write("{0} ", numbers2[i]);
                    }
                    else{
                        ans.Write("{0} ", numbers1[i]);
                    }
                }
            }
         }
     }
  }
    
}
