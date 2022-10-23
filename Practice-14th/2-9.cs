/*
II. Решить задачу, разработав собственную структуру для хранения информации
9) На основе данных входного файла составить список студентов, включающий фамилию,
факультет, курс, группу, 5 оценок. Вывести в новый файл информацию о тех студентах,
которые имеют хотя бы одну двойку, отсортировав их по курсу.
*/

using System;
using System.IO;
using System.Collections.Generic;

class HelloWorld {
    
    struct Student : IComparable<Student>{
        string surname;
        string fac;
        int course;
        int group;
        int[] marks;
        
        public Student(string surname, string fac, int course, int group, int[] marks){
            this.surname = surname;
            this.fac = fac;
            this.course = course;
            this.group = group;
            this.marks = marks;
        }
        
        public string Show(){
            string buff = "";
            buff += String.Format("{0}, {1} {2} {3}: ", surname, fac, course, group);
            for(int i = 0; i<5; i++){
                buff += String.Format("{0} ", marks[i]);
            }
            buff += String.Format("\n");
            return buff;
        } 
        
        public int CompareTo(Student obj) //проводим переопределением метода
            { 
                if(this.group==obj.group){
                    return 0;
                }
                else if(this.group>obj.group){
                    return -1;
                }
                else{
                    return 1;
                }
            }
    }
    
    static void Main() {
        using( StreamReader file1 = new StreamReader("1.txt")){
            using(StreamWriter ans = new StreamWriter("ans.txt")){
                string line;
                char[] separators = new char[] { ' ','\n','\t','\r'};
                
                List<Student> stud_list = new List<Student>();
                
                while ((line = file1.ReadLine()) != null)
                {
                    string[] info = line.Split(separators,StringSplitOptions.RemoveEmptyEntries);
                    int[] marks = new int[5];
                    
                    bool flag = false;
                    
                    for(int i = 0; i<5; i++){
                        marks[i] = int.Parse(info[i+4]);
                        if(marks[i]==2){
                            flag = true;
                        }
                    }
                    if(flag){
                    stud_list.Add(new Student(  info[0],
                                                info[1],
                                                int.Parse(info[2]),
                                                int.Parse(info[3]),
                                                marks  ));
                    }
                    
                }
                
                stud_list.Sort();
                
                foreach (Student stud in stud_list)
                {
                    ans.Write(stud.Show());
                }
        }
    }
        
    }
}
