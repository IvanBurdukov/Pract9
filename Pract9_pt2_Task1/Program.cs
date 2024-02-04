using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Pract9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите первое число:");
                double number1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                double number2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1 - сложение");
                Console.WriteLine("2 - вычитание");
                Console.WriteLine("3 - умножение");
                Console.WriteLine("4 - деление");

                int operation = int.Parse(Console.ReadLine());

                double result = 0;

                switch (operation)
                {
                    case 1:
                        result = number1 + number2;
                        break;
                    case 2:
                        result = number1 - number2;
                        break;
                    case 3:
                        result = number1 * number2;
                        break;
                    case 4:
                        if (number2 == 0)
                        {
                            throw new DivideByZeroException("Деление на ноль невозможно.");
                        }
                        result = number1 / number2;
                        break;
                    default:
                        throw new ArgumentException("Некорректный код операции.");
                }

                Console.WriteLine("Результат: " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Некорректный формат числа.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}