using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Запись_в_новый_массив
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n;
            double ch;
            double t;
        link1:
            int j = 0;
            int i = 0;
            int k = 1;
            Console.WriteLine("Введите число элементов массива ");
            string l = Console.ReadLine();

            if (l == "exit")
            {
                goto linkexit;
            }    

            if (byte.TryParse(l, out n))
            {
                n = Convert.ToByte(l);
            }
            else
            {
                Console.WriteLine("Error!");
                goto link1;
            }

            double[] array = new double[n];
            double[] arr = new double[n];
            Console.WriteLine();
            Console.WriteLine("Введите элементы массива");
            Console.WriteLine();
            while (i < n)
            {
        link2:
                Console.Write(k + " элемент массива = ");
                string element = Console.ReadLine();

                if (element == "exit")
                {
                    goto linkexit;
                }

                if (double.TryParse(element, out ch))
                {
                    array[i] = Convert.ToDouble(element);
                    arr[i] = Convert.ToDouble(element);
                    k++; i++;
                }
                else
                {
                    Console.WriteLine("Error!");
                    goto link2;
                }                
            }
            Console.WriteLine();
            Console.Write("Ваш массив: ");
            for (i = 0; i < n; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
            Console.WriteLine();

            //Console.WriteLine("Отсортированный по убыванию массив: ");
            for (j = 0; j < n - 1; j++)
            {
                for (i = 0; i < n - 1; i++)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        t = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = t;
                    }
                }
            }

            //Console.Write("Исходнный массив: ");
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();
            Console.Write("Сортированный массив: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Готово");
            Console.WriteLine();

        
            Console.Write(" Хотите выйти? (y/n): ");
            char inp = Convert.ToChar(Console.ReadLine());   //char inp = Char.Parse(Console.ReadLine());
            if (inp == 'y')
                Console.WriteLine(" Gg");                                    

            else
            {
                Console.WriteLine();
                goto link1;
            }
        linkexit:
            Console.WriteLine(" Gg");

        }
    }
}
