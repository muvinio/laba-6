using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseForm;

namespace windowsForm
{
    public partial class GuessingForm : Form
    {
        public GuessingForm()
        {
            InitializeComponent();

        }



        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuessAnswerForm form = new GuessAnswerForm();
            form.Show();
        }
        private void Solver(double a, double b)
        {
            double result;
            GuessAnswerClass guessAnswerClass = new GuessAnswerClass();
            result = GuessAnswerClass.FuncSolver(a, b);



        }



        private void GuessingForm_Load(object sender, EventArgs e)
        {

        }


        private void CheckingButton_Click(object sender, EventArgs e)
        {
            if (ABox.Text != "" && BBox.Text != "")
            {
                if (double.TryParse(ABox.Text, out double a))
                {
                    ConsoleBox.Text = "";
                    if (double.TryParse(BBox.Text, out double b))
                    {

                        ConsoleBox.Text = "";

                        GuessAnswerClass guessAnswerClass = new GuessAnswerClass();
                        if (guessAnswerClass.IsValid(a, b))
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
                                            ResultBox.Text = result.ToString();


                                            if (answer == result && value != 0)
                                            {
                                                ConsoleLabel.Text = "Вы угадали";
                                            }
                                            else if (answer != result && value == 1)
                                            {
                                                QuantityField.Text = "0";
                                                ConsoleLabel.Text = "Вы проиграли";
                                            }
                                            else if (answer != result && value != 0)
                                            {
                                                ConsoleLabel.Text = "Неправильно";
                                                QuantityField.Text = (value - 1).ToString();
                                            }

                                        }
                                        else
                                        {
                                            ConsoleLabel.Text = "Введите корректный ответ";
                                        }
                                    }
                                    else
                                    {
                                        ConsoleLabel.Text = "Введите ваш ответ";
                                    }
                                }
                                else
                                {
                                    ConsoleLabel.Text = "Введите корректное значение попыток";
                                }
                            }
                            else
                            {
                                ConsoleLabel.Text = "Введите число попыток";
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
            else
            {
                ConsoleBox.Text = "Введите все значения";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CheckingButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
