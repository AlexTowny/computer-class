/*
II. Использование структур данных.
Замечания.
1. Во всех задачах данного раздела подразумевается, что исходная информация хранится в
текстовом файле input.txt, каждая строка которого содержит полную информацию о некотором
объекте; результирующая информация должна быть записана в файл output.txt.
2. Для хранения данных внутри программы организовать одномерный массив структур или любую
другую подходящую коллекцию структур. Выбор коллекции обосновать. 

Задание 9. На основе данных входного файла составить список сотрудников
учреждения, включив следующие данные: ФИО, год принятия на работу, должность,
зарплата, рабочий стаж. Вывести в новый файл информацию о сотрудниках, имеющих
зарплату ниже определенного уровня, отсортировав их по рабочему стажу.
*/

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class HelloWorld {
    
    struct Employee : IComparable<Employee>{
        string surname;
        string name;
        string father;
        int year;
        string status;
        public int pay;
        int stage;
        
        public Employee(string surname, string name, string father, int year,string status,int pay,int stage){
            this.surname = surname;
            this.name = name;
            this.father = father;
            this.year = year;
            this.status = status;
            this.pay = pay;
            this.stage = stage;
        }
        
        public string Show(){
            string buff = "";
            buff += String.Format("{0} {1} {2}, {3}y. {4} {5}$ {6}y.\n", 
            surname, name, father, year, status, pay, stage);
            
            return buff;
        } 
    
        public int CompareTo(Employee obj) //проводим переопределением метода
            { 
                if(this.stage==obj.stage){
                    return 0;
                }
                else if(this.stage>obj.stage){
                    return 1;
                }
                else{
                    return -1;
                }
            }
    }
    
    static void Main() {
        int R = int.Parse(Console.ReadLine());
        
        using( StreamReader file1 = new StreamReader("1.txt")){
            using(StreamWriter ans = new StreamWriter("ans.txt")){
                string line;
                char[] separators = new char[] { ' ','\n','\t','\r'};
                
                List<Employee> empl_list = new List<Employee>();
                
                while ((line = file1.ReadLine()) != null)
                {
                    string[] info = line.Split(separators,StringSplitOptions.RemoveEmptyEntries);
                 
                    
                    empl_list.Add(new Employee( info[0],
                                                info[1],
                                                info[2],
                                                int.Parse(info[3]),
                                                info[4],
                                                int.Parse(info[5]),
                                                int.Parse(info[6])  ));
                    
                    
                }
                
                List<Employee> res = new List<Employee> ( from p in empl_list
                          where p.pay < R
                          select p);
                res.Sort();
                
                foreach (var empl in res)
                {
                    ans.Write(empl.Show());
                }
        }
    }
        
    }
}
