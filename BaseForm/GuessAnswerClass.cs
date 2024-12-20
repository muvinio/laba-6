using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsForm
{
    class GuessAnswerClass
    {
        double a;
        double b;
        double roundedResult;
        bool w;

        public static double FuncSolver(double a, double b)
        {
            double result = 0;
            double roundedResult = 0;
            result = Math.Sqrt((Math.Pow(Math.Sin(a), 2) + Math.Pow(Math.Cos(b), 3)) / (Math.Pow(Math.Sin(a), 3) - Math.Pow(Math.Cos(b), 2)));
            roundedResult = Math.Round(result, 2);
            return roundedResult;
        }


        public bool IsValid(double a, double b)
        {
            if (((Math.Pow(Math.Sin(a), 3) - Math.Pow(Math.Cos(b), 2)) != 0) && ((Math.Pow(Math.Sin(a), 2) + Math.Pow(Math.Cos(b), 3)) / (Math.Pow(Math.Sin(a), 3) - Math.Pow(Math.Cos(b), 2)) >= 0))
            {
                roundedResult = FuncSolver(a, b);
                return true;
            }
            else
            {
                return false;
            }
        }


        public static void Guessing(double correctAnswer, int n, TextBox FromField, TextBox ToField, TextBox NumbersField
            )
        {
            int i = 0;
            double userAnswer = 0;
            while (i < n)
            {
                ToField.Text= "Введите ваш ответ: ";
                bool k = false;
                while (!k)
                {
                    if (double.TryParse(FromField.Text, out double h))
                    {
                        k = true;
                        userAnswer = h;
                    }
                    else
                    {
                        ToField.Text = "Вы ввели не число";
                    }
                }
                if (userAnswer != correctAnswer)
                {
                    i++;
                    NumbersField.Text = "У вас осталось" + (n-i) +"попыток";
                }
                else
                {
                    ToField.Text = ("Вы угадали!");
                    i = 3;
                }
                if (i == 3)
                {
                    ToField.Text = ("Правильный ответ: "+ correctAnswer);
                    
                }
            }
        }
    }
}
