using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsForm
{
    
    
    
        public  class Check
        {
            SortingArraysForm sortingArraysForm = new SortingArraysForm();
            ///  <summary>Проверка введеного значения(цифра или нет)</summary>
            ///  <returns>Число если введенное значение - число</returns>
            public static double DigitCheck()
            {
                double l = 0;
                double u = 0;
                bool t = false;
                while (!t)
                {
                    t = double.TryParse(Console.ReadLine(), out l);
                    if (!t)
                        Console.WriteLine("Вы ввели не число. Введите число");
                    else
                    {
                        u = l;
                    }
                }
                return u;
            }
            ///  <summary>Проверка введеного значения на принадлежность к int</summary>
            ///  <returns>Число, если введенное число принадлежит типу int</returns>
            

            ///  <summary>Проверка значения длины массива</summary>
            ///  <returns>Длина массива, если введенное значение больше 0</returns>
            public void CheckingArrayLength(int l)
            {



            
            
            if (l<=0)
                {
                    sortingArraysForm.ConsoleBox.Text = ("Длина массива должна быть больше 0");
                    
                    
                }
                
            }

            /// <summary>
            /// Проверка введенного числа на принадлежность к отрезку от 1 до 9
            /// </summary>
            /// <returns>Число</returns>
            public static int GetValidNumberInput()
            {
                int number;
                while (!int.TryParse(Console.ReadLine(), out number) || number < 1 || number > 9)
                {
                    Console.WriteLine("Некорректный ввод. Введите число от 1 до 9.");
                }
                return number;
            }
        }
    
}
