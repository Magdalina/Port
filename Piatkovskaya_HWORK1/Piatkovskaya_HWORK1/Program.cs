using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piatkovskaya_HWORK1
{
    class Program
    {
        static void Main(string[] args)
        {



            /*Начальный вклад в банке равен 1000 руб. 
            Через каждый месяц размер вклада увеличивается на P процентов от имеющейся суммы 
            (P — вещественное число, 0 < P < 25). По данному P определить, через сколько месяцев размер вклада превысит 1100 руб.,
             и вывести найденное количество месяцев K (целое число) и итоговый размер вклада S (вещественное число).*/


            //double P, vklad = 1000;
            //int month = 0;
            //Console.Write("Введите процентную ставку: ");
            //string a;
            //a = Console.ReadLine();
            //P = Convert.ToDouble(a);
            //Console.WriteLine(P);

            //if (P > 0 && P <=25)
            //{

            //    do
            //    {
            //        vklad =vklad+(vklad* P / 100);
            //         month++;
            //    }
            //    while (vklad < 1100);
            //    Console.WriteLine("Количество месяцев: " + month);
            //    Console.WriteLine("Итоговый размер вклада: " + vklad);
            //}
            //else if(P<0 || P==0 ||P>25){ 
            //    Console.WriteLine("НЕ верный ввод процентной ставки!! "); 
            //}



            /////////////////////////////////////////////////////////////////////////////////////////////
            /* Дано целое число (N>0), найти число, полученное при прочтении числа справа налево*/

            Console.WriteLine("Введите число: ");
            string str = Console.ReadLine();
           // int len = str.Length;

            int ch;
            ch = Convert.ToInt32(str);
            Console.Write("Ваше число при прочтении справа налево: ");
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(ch % 10);
                ch /= 10;
            }

            Console.WriteLine("\t");









           



          
           

        }
    }
}
