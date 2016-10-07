using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Collections;


namespace Piatkovskaya_Collections
{
   
  

    class Collection_of_students//: IComparable
    {
       





        List<Stsudent> students = new List<Stsudent>();

        public void AddStudent(string sname, string name, string otchestvo, int age, string group)
        {
            Stsudent student = new Stsudent(sname, name, otchestvo, age, group);
            students.Add(student);
        }


      
        public void RemoveStudent(Stsudent student)
        {

            students.Remove(student);
        }



        public string GetStudent(int number)
        {

            return students[number].SName + " " + students[number].Name + " " + students[number].Otchestvo;
            

        }

        public void Show()
        {
            Console.WriteLine("_____________Список студентов:_________ ");
           
            foreach (var student in students)
            {
               
                Console.WriteLine(student.SName + "\t" + student.Name + "\t" + student.Otchestvo + "\t" + student.Age+ "\t"+ student.Group  );
               
            }
            students.Sort(delegate(Stsudent st1, Stsudent st2)
            { return st1.SName.CompareTo(st2.SName); });
            Console.WriteLine("__________Сортировка студентов по фамилии______________");
            foreach (var student in students)
            {
                
                Console.WriteLine(student.SName + "\t" + student.Name + "\t" + student.Otchestvo + "\t" + student.Age + "\t" + student.Group);

            }


        }

        public int GetCount()
        {
            return students.Count;
        }



   


    }
}
