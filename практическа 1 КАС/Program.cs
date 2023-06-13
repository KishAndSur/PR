using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практическа_1_КАС
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1");

            Console.WriteLine("Введите количество строк");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов");
            int n = int.Parse(Console.ReadLine());

            Random r = new Random();
            int z = m;
            if (n > m)
            {
                z = n;
            }

            int[] temp = new int[z];
            int[,] rer = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    rer[i, j] = r.Next(0, 9);

                }

            }

            int y = rer.GetLength(0);
            int x = rer.GetLength(1);

            Console.WriteLine("Ввывод:");
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {

                    Console.Write( rer[i, j] + ", ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nСортировка по строкам: ");
            for (int i = 0; i < z; i++)
            {
                for (int j = 0; j < z; j++)
                    temp[j] = rer[i, j];
                Array.Sort(temp);
                for (int k = 0; k < z; k++)
                {
                    rer[i, k] = temp[k];
                    Console.Write("{0}\t", rer[i, k]);

                }
                Console.WriteLine();
            }

            Console.WriteLine("\nСортировка по столбцам: ");
            for (int i = 0; i < z; i++)
            {
                for (int j = 0; j < z; j++)
                    temp[j] = rer[j, i];
                Array.Sort(temp);
                for (int k = 0; k < z; k++)
                    rer[k, i] = temp[k];
            }
            for (int i = 0; i < z; i++)
            {
                for (int j = 0; j < z; j++)
                    Console.Write("{0}\t", rer[i, j]);
                Console.WriteLine();
            }


            Console.WriteLine("Задание №2");

            var array = new int[3, 3];
            var Random = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = Random.Next(0, 9);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Задание №3");

            Random ran = new Random();
            Random ra = new Random();
            string[] ingredient = new string[] { "котлета", "солёные огурчики", "помидоры", "кетчуп", "салат", "лук", "майонез", "сыр", "ветчина", "острый перец" };

            Console.WriteLine("Ваш бургер:");

            Console.Write("БУЛКА ");
            for (int i = 0; i <= ra.Next(1, 10); i++)
            {
                Console.Write(ingredient[ran.Next(0, 9)] + ", ");
            }
            Console.WriteLine(" БУЛКА");

            Console.WriteLine("Задание №4");
         
           Random ram = new Random();
           string[] pip = new string[] { "Александров Артем", "Андриянинков Дмитрий", "Башенков Николай", "Блюдов Матвей", "Ванишнин Даниил",
               "Галинский Илья", "Гарелин Егор", "Дмитриев Кирилл", "Журавлева Алекса", "Золотков Сергей", "Иванов Антон", "Кишкина Анастасия",
               "Кононенко Илья", "Кузнецов Данила", "Лобанов Александр", "Максимов Андрей", "Овечёнков Максим", "Потехин Роман", "Прохорова Дарья",
               "Румянцев Илья", "Савочкин Андрей", "Сорокин Илья", "Суреев Александр", "Тихомиров Кирилл", "Фирстов Денис", "Хрулев Иван", "Цвигун Никита",
               "Чумаев Данила", "Шиканов Александр" };
           Console.Write(pip[ram.Next(0, 28)]);

            Console.ReadKey();
        }

    }
}