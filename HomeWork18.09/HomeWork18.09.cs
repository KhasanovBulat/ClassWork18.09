using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork18._09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task A1.1 а");
            Console.WriteLine("Введите количество секунд, прошедших  с начала суток:");
            double n = Convert.ToDouble(Console.ReadLine());
            double hours = Math.Floor(n / 3600);
            Console.WriteLine("Прошло полных {0} часов с начала суток", hours);

            Console.WriteLine("Task A1.1 б");
            Console.WriteLine("Введите количество секунд, прошедших  с начала суток:");
            n = Convert.ToDouble(Console.ReadLine());
            hours = Math.Floor(n / 3600);
            double minutes = Math.Floor((n - (hours * 3600)) / 60);
            Console.WriteLine("Прошло полных {0} минут с начала очередного часа", minutes);

            Console.WriteLine("Task A1.1 в");
            Console.WriteLine("Введите количество секунд, прошедших  с начала суток:");
            n = Convert.ToDouble(Console.ReadLine());
            hours = Math.Floor(n / 3600);
            minutes = Math.Floor((n - (hours * 3600)) / 60);
            double seconds = (n - (hours * 3600) - minutes * 60);
            Console.WriteLine("Прошло полных {0} секунд с начала очередной минуты", seconds);

            Console.WriteLine("Task A1.2");
            double SquareNumber = 543 / 130;
            Console.WriteLine("{0} квадратов можно отрезать от прямоугольника", SquareNumber);

            Console.WriteLine("Task A1.3");
            Console.WriteLine("Введите номер текущего месяца");
            int month_number = Convert.ToInt32(Console.ReadLine());
            int next_month = month_number - (month_number / 12 * 12) + 1;
            Console.WriteLine($"Сейчас {next_month} месяц");

            Console.WriteLine("Task A1.4");
            Console.WriteLine("Введите двузначное число");
            int number = Convert.ToInt32(Console.ReadLine());
            while (n>99 && n < 10)
            {
                Console.WriteLine("Введите двузначное число (от 10 до 99)");
                number = Convert.ToInt32(Console.ReadLine());
            }
            int dozens = (number / 10) % 10;
            int ones = number % 10;
            int numbers_sum = dozens + ones;
            int numbers_multiply = dozens * ones;
            Console.WriteLine($"Число десятков - {dozens} \nЧисло единиц - {ones} \nСумма цифр - {numbers_sum} \nПроизведение цифр - {numbers_multiply}");

            Console.WriteLine("Task A1.5");
            Console.WriteLine("Введите трехзначное число");
            int a = Convert.ToInt32(Console.ReadLine());
            int new_a = (a % 100) * 10 + a / 100;
            Console.WriteLine($"Полученное число - {new_a}");

            Console.WriteLine("Task A1.6");

            for (int x = 100; x < 999; x++)
            {
                if ((x % 10).ToString() + ((x - x % 10) / 10).ToString() == "237")
                {
                    Console.WriteLine(x);
                }
            }

            Console.WriteLine("Task A1.7");
            Console.WriteLine("Введите цифры первого числа");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите цифры второго числа");
            int b2 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int dozens12 = int.Parse(a2.ToString() + b2.ToString());
            int ones12 = int.Parse(a1.ToString() + b1.ToString());
            int summ = dozens12 + ones12;
            int c2 = summ / 10;
            int c1 = summ % 10;
            Console.WriteLine($"Десятки нового числа - {c2}\nЕдиницы нового числа - {c1}");

            Console.WriteLine("Task A1.8");
            Console.WriteLine("Введите k");
            int k = Convert.ToInt32(Console.ReadLine());
            if (k % 3 == 0)
            {
                Console.WriteLine(k / 3 % 10);
            }
            if (k % 3 == 1)
            {
                Console.WriteLine("1");
            }
            if (k % 3 == 2)
            {
                Console.WriteLine((k + 2) / 30);
            }

            Console.WriteLine("Task A1.9");
            bool A = true;
            bool B = false;
            bool C = false;
            Console.WriteLine((A ^ B).ToString());
            Console.WriteLine((A & B).ToString());
            Console.WriteLine((C ^ B).ToString());

            Console.WriteLine("Task A1.10");
            bool X = Convert.ToBoolean(Console.ReadLine());
            bool Y = Convert.ToBoolean(Console.ReadLine());
            bool Z = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(!(X | Y) & (!X | !Z));
            Console.WriteLine(!(!X & Y) & (X & !Z));
            Console.WriteLine(X | !Y | !(X | !Z));













        }
        
    }
}
