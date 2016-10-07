using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piatkovskaya_HOME_WORK2
{
    class Program
    {
        static void statistic(string str)
        {
            int kol_lover = 0;
            int kol_upper = 0;
            int kol_num = 0;
            int kol_letter = 0;
            int kol_space = 0;
            int kol_symbol = 0;

            int size = str.Length;

            for (int i = 0; i < size; i++)
            {

                if (char.IsLower(str[i]))
                {
                    kol_lover++;

                }
                else if (char.IsUpper(str[i]))
                {
                    kol_upper++;

                }
                else if (char.IsNumber(str[i]))
                {
                    kol_num++;

                }
                //else if (char.IsLetter(str[i]))
                //{
                //    kol_letter++;

                //}
                else if (char.IsWhiteSpace(str[i]))
                {
                    kol_space++;

                }
                else if (char.IsPunctuation(str[i]))
                {
                    kol_symbol++;

                }
                kol_letter = kol_lover + kol_upper;
            }
            Console.Write(" \n кол-во символов общее:" + str.Length + " \n кол-во букв:" + kol_letter + " \n кол-во букв нижнего регистра: " + kol_lover + " \n кол-во букв верхнего регистра: " + kol_upper);
            Console.WriteLine(" \n кол-во цифр:" + kol_num + " \n кол-во знаков пунктуации:" + kol_symbol + " \n кол-во пробелов:" + kol_space);
        }






        static void Main(string[] args)
        {


            /*10. создать метод принимающий, введенную пользователем строку и выводящий статистику по этой 
                 строке на экран. статистика должна включать общее количество символов, 
                 количество букв(и сколько в верхнем регистре и нижнем), количество цифр, 
                 количество символов пунктуации и количество пробельных символов.*/
            string str;
            Console.WriteLine("Введите строку");
            str = Console.ReadLine();
            Console.WriteLine(str);

            statistic(str);








            /*7.Заменить все элементы k-й строки и s-го столбца двумерного массива противоположными по знаку 
            (элемент, стоящий на пересечении строки и столбца, не изменять).*/

            //int col, row, k, s;
            //Console.WriteLine("Введите кол-во строк массива:");
            //col = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите кол-во строк массива:");
            //row = Convert.ToInt32(Console.ReadLine());
            //int[,] arr = new int[col, row];
            //Random r = new Random();
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        arr[i, j] = r.Next(20);
            //        Console.Write(arr[i, j] + "\t");
            //    } Console.Write("\n");
            //}

            //Console.WriteLine("Введите номер строки от 1 до {0}:", col);
            //k = Convert.ToInt32(Console.ReadLine());
            //if (k > col) { Console.WriteLine("Не верный ввод строки!!!");   }
            //Console.WriteLine("Введите номер столбцаот 1 до {0}:", row);
            //s = Convert.ToInt32(Console.ReadLine());
            //if (s > row) { Console.WriteLine("Не верный ввод столбца!!!"); }
            //else
            //{
            //    for (int i = 0; i < arr.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < arr.GetLength(1); j++)
            //        {
            //            if (i == k || j == s)
            //            {
            //                arr[i, j] = arr[i, j] * (-1);
            //                arr[k, s] = arr[i, j];
            //            }

            //            Console.Write(arr[i, j] + "\t");
            //        } Console.Write("\n");
            //    }
            //}





            /*5.С помощью датчика случайных чисел создать массив целых чисел,
                элементы которого отличаются от своих соседей по массиву на малую величину, 
                например, не более, чем на 10 %. 
                (Такие массивы находят применение, например, при создании проверочных тестов в задачах об изменении 
                   атмосферного давления или температуры воздуха по дням месяца и т. п.)*/

          
            //int[] myArr = new int[15];
            //Random r = new Random();
            //myArr[0] = r.Next(600);

            //Console.WriteLine("\n");
            //Console.Write(myArr[0] + "\t");
            //for (int i = 1; i < myArr.Length; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        myArr[i] = ((myArr[i - 1] * 10) / 100) + myArr[i - 1];
                   
            //    }
            //    else {
            //        myArr[i] = myArr[i - 1] - ((myArr[i - 1] * 10) / 100);
            //    }
               
            //    Console.Write(myArr[i] + "\t");
            //}
            //Console.WriteLine();




            /*
             * //**************************************************************************************************

 
            int col, row, k, s;
            do
            {
                Console.WriteLine("Введите кол-во строк массива:");
              
            } while (Int32.TryParse(Console.ReadLine(), out col) == false); //не позволит ввести буквы

            do
            {
                Console.WriteLine("Введите кол-во столбцов массива:");
              
            } while (Int32.TryParse(Console.ReadLine(), out row) == false); //не позволит ввести буквы

            int[,] arr = new int[col, row];
            Random r = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = r.Next(20);
                    Console.Write(arr[i, j] + "\t");
                } Console.Write("\n");
            }
            do
            {
                Console.WriteLine("Введите номер строки от 1 до {0}:", col);
            } while (Int32.TryParse(Console.ReadLine(), out k) == false || k <= 0 || k > col);

            do
            {
                Console.WriteLine("Введите номер столбца от 1 до {0}:", row);
            } while (Int32.TryParse(Console.ReadLine(), out s) == false || s <= 0 || s > row);

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i == k - 1 || j == s - 1)&& !(i==k - 1  && j== s - 1))
                    {
                        arr[i, j] *= (-1);
                    }

                    Console.Write(arr[i, j] + "\t");
                } Console.Write("\n");
            }*/





        }
    }
}
