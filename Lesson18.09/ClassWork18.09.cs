using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18._09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Console.WriteLine("Тип double:" + double.MinValue.ToString() + " " + double.MaxValue.ToString() + "\n");
            Console.WriteLine("Тип float:" + float.MinValue.ToString() + " " + float.MaxValue.ToString() + "\n");
            Console.WriteLine("Тип int:" + int.MinValue.ToString() + " " + int.MaxValue.ToString() + "\n");
            Console.WriteLine("Тип byte:" + byte.MinValue.ToString() + " " + byte.MaxValue.ToString() + "\n");
            Console.WriteLine("Тип long:" + long.MinValue.ToString() + " " + long.MaxValue.ToString() + "\n");

            Console.WriteLine("Task 2");
            Console.WriteLine("Введите Ваше имя");
            string UserName = Console.ReadLine();
            Console.WriteLine("Введите название города");
            string CityName = Console.ReadLine();
            Console.WriteLine("Введите Ваш возраст");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Ваш PIN-код");
            int PIN_code = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} - Ваше имя \n{1} - Название города \n{2} - Ваш возраст \n{3} - PIN-код", UserName, CityName, Age, PIN_code); ;


            Console.WriteLine("Task 3");
           
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            string substr = "";
            foreach (var ind in str)
            {
                if (char.IsUpper(ind))
                {
                    substr += char.ToLower(ind);
                }
                else
                {
                    substr += char.ToUpper(ind);
                }

            }
            Console.WriteLine(substr);

            Console.WriteLine("Task 4");
            string stroka = Console.ReadLine();
            string podstroka = Console.ReadLine();
            int Count = (stroka.Length - stroka.Replace(podstroka, "").Length) / podstroka.Length;
            Console.WriteLine($"{Count}");

            Console.WriteLine("Task 5");
            Console.WriteLine("Введите значение скорости (в км/ч)");
            double speed1 = Convert.ToDouble(Console.ReadLine());
            double speed2 = (speed1 * 100000) / 3600;
            double speed2_round = Math.Floor(speed2);
            Console.WriteLine("Результат (в см/с): {0}", speed2_round);
            

            Console.WriteLine("Task 6");
            Console.WriteLine("Введите возраст отца");
            int dad_age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите возраст сына");
            int son_age = Convert.ToInt32(Console.ReadLine());
            int difference = dad_age - son_age;
            if (dad_age / son_age >= 2 || son_age == 0) 
            {
                int years1 = 2 * difference - dad_age;
                Console.WriteLine("Через {0} лет отец будет вдвое старше сына", years1);
            }

            if (dad_age / son_age < 2 || son_age == 0) 
            {
                int years2 = dad_age - 2 * difference;
                Console.WriteLine("{0} лет назад отец был вдыое старше сына", years2);
            }

            Console.WriteLine("Task 7"); ///???
            Console.WriteLine("Введите стандартную цену");
            double normprice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите скидку в Duty Free (%)");
            double SalePrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость отпуска");
            double HolidayPrice = Convert.ToInt32(Console.ReadLine());
            double Saved = (SalePrice/100) * normprice;
            double returned = HolidayPrice / (Saved);
            if (SalePrice ==0)
            {
                Console.WriteLine("Некорректное значение перменной SalePrice");
            }
            else
            {
                Console.WriteLine($"Нужно купить {Math.Floor(returned)} бутылок");
            }

            
            Console.ReadKey();
           
        }
    }
}
