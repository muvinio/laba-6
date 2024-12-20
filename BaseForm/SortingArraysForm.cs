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
    public partial class SortingArraysForm : Form
    {
        public SortingArraysForm()
        {
            InitializeComponent();
        }
        Arrays arr;
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GenerationButton_Click(object sender, EventArgs e)
        {
            Check check = new Check();
            
            
            MinElementBox.Text = "";
            MaxElementBox.Text = "";
            AverageBox.Text = "";
            if (LengthField.Text != "")
            {
                if (int.TryParse(LengthField.Text, out int n))

                {

                    if (n > 0)
                    {
                        ConsoleBox.Text = "";
                        if (n <= 10)
                        {
                            ConsoleBox.Text = "";
                            arr = new Arrays(n);
                            arr.Creating();
                            arr.OutPutting();
                            this.dataGridView1.Rows.Clear();
                            int[] array = arr.array;
                            for (int i = 0; i < arr.length; i++)
                            {

                                dataGridView1[i, 0].Value = array[i];
                            }
                        }
                        else
                        {
                            ConsoleBox.Text = "Вывести массив на экран не получится";
                        }
                    }
                    else
                    {
                        ConsoleBox.Text = "Длина массива должна быть >0";
                    }
                }
                else
                {
                    ConsoleBox.Text = "Введите корректное значение";
                }
            }
            else
            {
                arr = new Arrays();

                arr.Creating();
                arr.OutPutting();
                this.dataGridView1.Rows.Clear();
                int[] array = arr.array;
                for (int i = 0; i < arr.length; i++)
                {

                    dataGridView1[i, 0].Value = array[i];
                }
            }
        }

        private void SortingButton_Click(object sender, EventArgs e)
        {
            arr.ShellSort();
            for (int i = 0; i < arr.length; i++)
            {

                dataGridView1[i, 0].Value = arr.array[i];
            }
        }

        private void SearchingMinElementButton_Click(object sender, EventArgs e)
        {
            int min = arr.array[0];
            for (int i = 0; i < arr.length; i++)
            {
                if (arr.array[i] < min) { min = arr.array[i]; }
            }
            MinElementBox.Text = min.ToString();
        }

        private void SearchMaxElementButton_Click(object sender, EventArgs e)
        {
            int max = arr.array[0];
            for (int i = 0; i < arr.length; i++)
            {
                if (arr.array[i] > max) { max = arr.array[i]; }
            }
            MaxElementBox.Text = max.ToString();
        }

        private void SearchAverageButton_Click(object sender, EventArgs e)
        {
            int average = 0;
            for (int i = 0; i < arr.length; i++)
            {
                average += arr.array[i];
            }
            AverageBox.Text = average.ToString();
        }

        private void ColouringButton_Click(object sender, EventArgs e)
        {
            int min = arr.array[0];
            for (int i = 0; i < arr.length; i++)
            {
                if (arr.array[i] < min) { min = arr.array[i]; }
            }
            int max = arr.array[0];
            for (int i = 0; i < arr.length; i++)
            {
                if (arr.array[i] > max) { max = arr.array[i]; }
            }
            for (int i = 0; i < arr.length; i++)
            {
                int el = int.Parse(dataGridView1[i, 0].Value.ToString());
                if (el == min)
                {
                    dataGridView1[i, 0].Style.BackColor = Color.Red;
                }
                if (el == max)
                {
                    dataGridView1[i, 0].Style.BackColor = Color.Green;
                }
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
