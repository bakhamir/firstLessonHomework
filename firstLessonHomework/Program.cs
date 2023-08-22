using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLessonHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CLI();
            Console.ReadKey();
        }
        /// <summary>
        /// Простой метод для приветствования пользователя 
        /// </summary>
        static void Hello()
        {
            Console.Write("Введите свое ФИО - ");
            string FIO = Console.ReadLine();
            Console.WriteLine("Приветствую тебя - {0}",FIO);
        }
        /// <summary>
        /// Простой калькулятор суммы двух чисел
        /// </summary>
        static void Sum()
        {
            int a = 0;int b = 0;
            Console.Write("Введите первое число - ");
            Int32.TryParse(Console.ReadLine(),out a);
            Console.Write("Введите второе число - ");
            Int32.TryParse(Console.ReadLine(), out b);
            int result = a + b;
            Console.WriteLine("Результат! - {0}",result);
        }
        static void CLI()
        {
            Console.WriteLine("Выберите Метод для исполнения");
            Console.WriteLine("Приветствие - Hello");
            Console.WriteLine("Сумма чисел - Sum");
            string choice = Console.ReadLine();
            if(choice == "Hello")
            {
                Hello();
            }
            else if(choice == "Sum")
            {
                Sum();
            }
        }
    }

}
