using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;


namespace Piatkovskaya_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var group = new Collection_of_students();
            group.AddStudent("Петренко", "Олеся", "Викторовна", 25, "ХЕ-091");
            group.AddStudent("Чумак   ", "Олег", " Петрович", 24, "  ХЕ-091");
            group.AddStudent("Алексина", "Мария", "Андреевна", 19, "ХЕ-091");
            group.AddStudent("Фоксин   ", "Антон", " Олегович", 20, "  ХЕ-091");

           group.Show();
            Console.WriteLine("\n\n ");
            Console.WriteLine(" количество студентов  " + group.GetCount());




          
          
            
            //Console.WriteLine("\n _________________Добавление________________");
            // string sname;
            //do
            //{
            //    Console.Write("Введите фамилию: ");
            //    sname = Console.ReadLine();
            //    if ((sname.Any(char.IsPunctuation)) || (sname.Any(char.IsNumber)) || (sname.Any(char.IsWhiteSpace)) || sname == string.Empty)
            //    {
            //        Console.WriteLine("Сделайте правильный ввод фамилии!!");
                   
            //    }
            //} while (((sname.Any(char.IsPunctuation)) || (sname.Any(char.IsNumber)) || (sname.Any(char.IsWhiteSpace)) || sname == string.Empty));


            //string name;
            //do
            //{
            //    Console.Write("Введите имя: ");
            //    name = Console.ReadLine();
            //    if ((name.Any(char.IsPunctuation)) || (name.Any(char.IsNumber)) || (name.Any(char.IsWhiteSpace)) || name == string.Empty)
            //    {
            //        Console.WriteLine("Сделайте правильный ввод имени!!");

            //    }
            //} while (((name.Any(char.IsPunctuation)) || (name.Any(char.IsNumber)) || (name.Any(char.IsWhiteSpace)) || name == string.Empty));

            //string otch;
            //do
            //{
            //    Console.Write("Введите отчество: ");
            //    otch = Console.ReadLine();
            //    if ((otch.Any(char.IsPunctuation)) || (otch.Any(char.IsNumber)) || (otch.Any(char.IsWhiteSpace)) || otch == string.Empty)
            //    {
            //        Console.WriteLine("Сделайте правильный ввод отчества!!");

            //    }
            //} while (((otch.Any(char.IsPunctuation)) || (otch.Any(char.IsNumber)) || (otch.Any(char.IsWhiteSpace)) || otch == string.Empty));
       
               
              

            //    int age;
            //   do
            //    {
            //        Console.WriteLine("Введите возраст:");

            //    } while (Int32.TryParse(Console.ReadLine(), out age) == false);


            //   string gro;
            //   do
            //   {
            //       Console.Write("Введите группу: ");
            //       gro = Console.ReadLine();
            //   } while (gro == string.Empty);
       
               

        
            //    group.AddStudent(sname, name,otch, age ,gro);

            //    group.Show();
            //    Console.WriteLine("Общее количество студентов в группе " + group.GetCount());
              
            ////////////////////////////////////////////////////////////////////////////////////////////////////////



             Console.WriteLine("\n _______Поиск по порядковому номеру в списке______________________" );
            int number;
           try{
            do
            {
                Console.WriteLine("Введите  номер студента от 1 до {0}",group.GetCount());
            } while (Int32.TryParse(Console.ReadLine(), out number) == false);
           
     
                Console.WriteLine(group.GetStudent(number - 1));
            }
                catch(ArgumentOutOfRangeException ex)
           {
               Console.WriteLine(ex.Message);
                   Console.WriteLine("Please write correct number!!!!");
           }
               //////////////////////////////////////////////////


          


        }
    }
}
