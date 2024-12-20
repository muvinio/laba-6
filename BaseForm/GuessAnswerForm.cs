using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace windowsForm
{
    public partial class GuessAnswerForm : Form
    {
        public GuessAnswerForm()
        {
            InitializeComponent();


        }



        public double aValue, bValue;

        public void StartButton_Click(object sender, EventArgs e)
        {
            GuessingForm guessingForm = new GuessingForm();

            if (AFieldValue.Text != "" && BFieldValue.Text != "")
            {
                if (double.TryParse(AFieldValue.Text, out double a))
                {
                    ConsoleBox.Text = "";
                    if (double.TryParse(BFieldValue.Text, out double b))
                    {

                        ConsoleBox.Text = "";

                        GuessAnswerClass guessAnswerClass = new GuessAnswerClass();
                        if (guessAnswerClass.IsValid(a, b))
                        {

                        }
                        else
                        {
                            ConsoleBox.Text = "Функция не существует";
                        }

                    }
                    else
                    {
                        ConsoleBox.Text = "Введите корректное значение параметра b";
                    }
                }
                else
                {
                    ConsoleBox.Text = "Введите корректное значение параметра a";
                }


            }
            else
            {
                ConsoleBox.Text = "Введите все значения";
            }

        }

        public void GettingAValues()
        {
            this.aValue = double.Parse(AFieldValue.Text);
        }
        public void GettingBValues()
        {
            this.bValue = double.Parse(BFieldValue.Text);

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void CheckingButton_Click(object sender, EventArgs e)
        {
            GuessAnswerClass guessAnswerClass = new GuessAnswerClass();
            double a, b; ;
            if (double.TryParse(AFieldValue.Text, out a))
            {
                ConsoleBox.Text = "";
                if (double.TryParse(BFieldValue.Text, out b))
                {
                    if (guessAnswerClass.IsValid(a, b))
                    {
                        if (AFieldValue.Text != "" && BFieldValue.Text != "" && QuantityField.Text !="" )
                        {
                            
                               
                                

                                    double result = GuessAnswerClass.FuncSolver(a, b);

                                    if (QuantityField.Text != "")
                                    {
                                        if (int.TryParse(QuantityField.Text, out int value))
                                        {
                                            if (UserAnswerField.Text != "")
                                            {
                                                if (double.TryParse(UserAnswerField.Text, out double answer))
                                                {
                                                    ;


                                                    if (answer == result && value != 0)
                                                    {
                                                        ConsoleBox.Text = "Вы угадали";
                                                    }
                                                    else if (answer != result && value == 1)
                                                    {
                                                        QuantityField.Text = "0";
                                                        ConsoleBox.Text = "Вы проиграли";
                                                    }
                                                    else if (answer != result && value != 0)
                                                    {
                                                        ConsoleBox.Text = "Неправильно";
                                                        QuantityField.Text = (value - 1).ToString();
                                                    }

                                                }
                                                else
                                                {
                                                    ConsoleBox.Text = "Введите корректный ответ";
                                                }
                                            }
                                            else
                                            {
                                                ConsoleBox.Text = "Введите ваш ответ";
                                            }
                                        }
                                        else
                                        {
                                            ConsoleBox.Text = "Введите корректное значение попыток";
                                        }
                                    }
                                    else
                                    {
                                        ConsoleBox.Text = "Введите число попыток";
                                    }




                                
                           


                        }
                        else
                        {
                            ConsoleBox.Text = "Введите все значения";
                        }
                    }

                    else
                    {
                        ConsoleBox.Text = "Функция не существует";
                    }
                }
                else
                {
                    ConsoleBox.Text = "Введите корректное значение параметра b";
                }
            }
            else
            {
                ConsoleBox.Text = "Введите корректное значение параметра a";
            }
        }
    }
}
