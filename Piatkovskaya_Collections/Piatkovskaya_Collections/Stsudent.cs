using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piatkovskaya_Collections
{
    class Stsudent
    {
        string sname;
        string name;
        string otchestvo;
        int age;
        string group;
       
        static readonly string NameUniversity;

       
        public int Age
        {
            set {
                do
                {
                    age = (value < 0 || value > 60) ? 0 : value;

                } while (Int32.TryParse(Console.ReadLine(), out age) == false); 
               
                
            }
            get { return age; }
        }



        public string SName
        {

            set
            {
                if ((value.Any(char.IsPunctuation)) || (value.Any(char.IsNumber)) || (value.Any(char.IsWhiteSpace)) && sname == string.Empty)
             
                {
                    Console.WriteLine("Сделайте правильный ввод фамилии!!");
                 }
                else
                {
                    sname = value;
                }
          }
                
          get { return sname != null ? sname : "not set"; }
        }

        public string Name
        {

            set
            {
                if ((value.Any(char.IsPunctuation)) || (value.Any(char.IsNumber)) || (value.Any(char.IsWhiteSpace))  && sname == string.Empty)
                
                {
                    Console.WriteLine("Сделайте правильный ввод имени!!");
                }
                else
                {
                    name = value;
                }
            }

            get { return name != null ? name : "not set"; }
        }


        public string Otchestvo
        {

            set
            {
                if ((value.Any(char.IsPunctuation)) || (value.Any(char.IsNumber)) || (value.Any(char.IsWhiteSpace)) || sname == null && sname == string.Empty)
               
                {
                    Console.WriteLine("Сделайте правильный ввод отчества!!");
                }
                else
                {
                    otchestvo = value;
                }
            }

            get { return otchestvo != null ? otchestvo : "not set"; }
        }


        public string Group
        {
            set
            {
                group = value;
                int size = 10;
                char[] chrArr = new char[size];
                

                if (value.Length < 10) group = value;
                else
                {
                    Console.WriteLine("Сделайте правильный ввод группы(не более 10 символов)!!");
                    group = "--";
                }

            }
            get { return group != null ? group : "not set"; }
        }

        static Stsudent()
        {
            NameUniversity = "ОНПУ";

        }
        static string Name__University
        {
            
            get { return NameUniversity; }

        }

        //public Stsudent(string sname, string name, string otchestvo)
        //    : this()
        //{
        //    this.sname = sname;
        //    this.name = name;
        //    this.otchestvo = otchestvo;
        //}
        //public Stsudent(string sname, string name, string otchestvo, int age, string group)
        //{
        //    this.sname = SName;
        //    this.name = Name;
        //    this.otchestvo = Otchestvo;
        //    if (age < 0) { Console.WriteLine("Не коректный ввод возраста!!"); }
        //    else this.age = Age;
        //    this.group = Group;
        //}
      


      

        public Stsudent()
        {
            sname = "noSname";
            name = "noName";
            otchestvo ="noOtchestvo";
            age = 0;
            group = "-";       }

        public void Show()
        {
            Console.Write("\n___________________________________________\n");
            Console.WriteLine("Фамилия: " + sname);
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Отчество: " + otchestvo);
            Console.WriteLine("Возраст: " + age);
            Console.WriteLine("Группа: " + group);
         }

     

    

        public override string ToString()
        {
            return string.Format(" SureName: {0}\n  Name: {1}\nPatronymic: {2}\n Age: {3}\n Group: {4}\n University: {5}\n ", this.SName, this.Name, this.Otchestvo, this.Age, this.Group, Stsudent.Name__University);
        }

      ////////////////
                public Stsudent(string sname, string name, string otchestvo): this()
        {
            this.sname = sname;
            this.name = name;
            this.otchestvo = otchestvo;
        }
                public Stsudent(string sname, string name, string otchestvo, int age, string group)
                {
                    this.sname = sname;
                    this.name = name;
                    this.otchestvo = otchestvo;
                    this.age = age;
                    this.group = group;
                }





















    }
}
