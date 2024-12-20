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
    public partial class MagicSquareForm : Form
    {
        public MagicSquareForm()
        {
            InitializeComponent();
        }

        


        private void MagicSquareForm_Load(object sender, EventArgs e)
        {
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView2.ScrollBars = ScrollBars.None;
            for (int i = 0; i < 2; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView2.Rows.Add();
            }
            for (int i = 1; i < 4; i++)
            {
                dataGridView2[0, i - 1].Value = i;
            }
            for (int i = 0; i < 1; i++)
            {
                dataGridView1.Rows.Add();
            }
        }

        
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
               
                
                
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {

                  

                }





        }
        public int GetRowSum(int row)
        {
            int sum = 0;
            for (int j = 0; j < 3; j++)
            {
                sum += int.Parse(dataGridView1[j, row].Value.ToString());
            }
            return sum;
        }

        public int GetColumnSum(int col)
        {
            
            int sum = 0;
            for (int i = 0; i <3; i++)
            {
                sum += int.Parse(dataGridView1[col, i].Value.ToString());
            }
            return sum;
        }

        public int GetDiagonalSum(int row, int col)
        {
            MagicSquareForm form = new MagicSquareForm();

            int sum = 0;
            int i = row;
            int j = col;
            while (i >= 0 && i < 3 && j >= 0 && j < 3)
            {
                sum += int.Parse(dataGridView1[j, i].Value.ToString());
                i += 1;
                j += (col == 0) ? 1 : -1;
            }
            return sum;
        }






        private void CheckButton_Click(object sender, EventArgs e)
        {
            int sum;
            bool[] usedNumbers = new bool[9];
            
            int k=0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (dataGridView1[j, i].Value != null)
                    {
                        k += 1;
                        if (int.TryParse(dataGridView1[j, i].Value.ToString(), out int value))
                        {
                            for (int v =0; v<9;v++)
                            {
                                if (value == v) usedNumbers[v] = true;
                            }
                        }
                            
                        else
                        {
                            MessageBox.Show("Введите корректные значения ( 1 - 9 )");
                        }
                    }
                }
            }
            for (int i = 0; i < 9; i++)
            {
                if (usedNumbers[i] == false) ConsoleBox.Text = "Цифры не должны повторяться";
            }
            
            if (k == 9)
            {


                for (int p = 0; p < 3; p++)
                {
                    if (GetRowSum(p) != 15 || GetColumnSum(p) != 15)
                    {
                        MessageBox.Show("Вы проиграли");
                        break;
                    }
                    if (GetDiagonalSum(0, 0) == 15 && GetDiagonalSum(0, 3 - 1) == 15)
                    {
                        MessageBox.Show("Вы победили");
                        break;
                    }
                }

                ///if (game.IsMagicSquare())
                ///{
                ///    

                ///}
                ///else
                ///{
                /// 
                ///}

            }
            else
            {
                MessageBox.Show("Введите все значения");
            }

            
            

        }
    }
}
