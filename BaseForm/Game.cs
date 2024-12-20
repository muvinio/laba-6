using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsForm
{
    
    public class Game
    {
        private const int FIELD_SIZE = 3;
        private int[,] field;
        private bool[] usedNumbers;

        /// <summary>
        /// Основной метод класса
        /// </summary>
        public void MagicSquareGame()
        {



            InitializeField();

            while (true)
            {
                PrintField();
                FillingSquare();



                if (IsMagicSquare())
                {
                    PrintField();
                    Console.WriteLine("Поздравляем! Вы собрали магический квадрат!");
                    break;
                }
                else if (IsFieldFull())
                {
                    PrintField();
                    Console.WriteLine("Игра окончена. Вы не смогли собрать магический квадрат.");
                    break;
                }
            }
            Console.WriteLine("Нажмите любую кнопку, чтобы продолжить");
            Console.ReadKey();
        }

        /// <summary>
        /// Инициализация массивов
        /// </summary>
        private void InitializeField()
        {

            field = new int[FIELD_SIZE, FIELD_SIZE];
            usedNumbers = new bool[9];

        }

        /// <summary>
        /// Метод выводит массив на экран
        /// </summary>
        private void PrintField()
        {
            Console.WriteLine("Игровое поле:");
            for (int i = 0; i < FIELD_SIZE; i++)
            {
                for (int j = 0; j < FIELD_SIZE; j++)
                {
                    Console.Write(field[i, j] != 0 ? field[i, j] + " " : "_ ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Проверка корректного выбора строки
        /// </summary>
        /// <returns>Номер строки</returns>
        private int GetValidRowInput()
        {
            int row;
            while (!int.TryParse(Console.ReadLine(), out row) || row < 0 || row >= FIELD_SIZE)
            {
                Console.WriteLine("Некорректный ввод. Введите номер строки от 0 до 2.");
            }
            return row;
        }

        /// <summary>
        /// Проверка корректного выбора столбца
        /// </summary>
        /// <returns>Номер столбца</returns>
        private int GetValidColumnInput()
        {
            int col;
            while (!int.TryParse(Console.ReadLine(), out col) || col < 0 || col >= FIELD_SIZE)
            {
                Console.WriteLine("Некорректный ввод. Введите номер столбца от 0 до 2.");
            }
            return col;
        }
        /// <summary>
        /// Проверка введенного числа
        /// </summary>
        /// <param name="number">Число, введенное пользователем</param>
        /// <param name="row">Строка, выбранная пользователем</param>
        /// <param name="col">Столбец, выбранный пользователем</param>
        /// <returns></returns>
        private bool IsValidInput(int number, int row, int col)
        {
            return number >= 1 && number <= 9 &&
                    row >= 0 && row < FIELD_SIZE &&
                    col >= 0 && col < FIELD_SIZE &&
                    !usedNumbers[number - 1] &&
                    field[row, col] == 0;
        }

        /// <summary>
        /// Получение суммы всех элементов строки
        /// </summary>
        /// <param name="row">номер строки</param>
        /// <returns>Сумму строки</returns>
        public int GetRowSum(int row)
        {
            MagicSquareForm form = new MagicSquareForm();
            int sum = 0;
            for (int j = 0; j < 3; j++)
            {
                sum += int.Parse(form.dataGridView1[j, row].Value.ToString());
            }
            return sum;
        }

        /// <summary>
        /// Получение суммы всех элементов столбца
        /// </summary>
        /// <param name="col">номер столбца</param>
        /// <returns>Сумму столбца</returns>
        public int GetColumnSum(int col)
        {
            MagicSquareForm form = new MagicSquareForm();
            int sum = 0;
            for (int i = 0; i < FIELD_SIZE; i++)
            {
                sum += int.Parse(form.dataGridView1[col, i].Value.ToString());
            }
            return sum;
        }
        /// <summary>
        /// Получение суммы всех элементов в диагонали
        /// </summary>
        /// <param name="row">номер строки</param>
        /// <param name="col">номер столбца</param>
        /// <returns>Сумму диагонали</returns>
        private int GetMainDiagonalSum()
        {
            MagicSquareForm form = new MagicSquareForm();

            int sum = 0;
            
            int j = 0;
            for(int i =0; i<3;i++)
            {
                
                
                sum+= int.Parse(form.dataGridView1[j, i].Value.ToString());
                
                j += 1;
                
            }
            
            return sum;
        }
        private int GetSecondDiagonalSum()
        {
            MagicSquareForm form = new MagicSquareForm();

            int sum = 0;

            int j = 2;
            for (int i = 0; i < 3;)
            {


                sum += int.Parse(form.dataGridView1[j, i].Value.ToString());
                
                j -= 1;

            }
            {


            }
            return sum;
        }
        public int GetDiagonalSum(int row, int col)
        {
            MagicSquareForm form = new MagicSquareForm();

            int sum = 0;
            int i = row;
            int j = col;
            while (i >= 0 && i < FIELD_SIZE && j >= 0 && j < FIELD_SIZE)
            {
                sum += int.Parse(form.dataGridView1[j, i].Value.ToString());
                i += 1;
                j += (col == 0) ? 1 : -1;
            }
            return sum;
        }

        /// <summary>
        /// Проверка поля на соответствие условиям магического квадрата
        /// </summary>
        /// <returns>Соответствует/ не соответствует</returns>
        public bool IsMagicSquare()
        {
            

            return GetDiagonalSum(0, 0) == 15 && GetDiagonalSum(0, FIELD_SIZE - 1) == 15;

        }

        /// <summary>
        /// Заполнение массива элементами
        /// </summary>
        private void FillingSquare()
        {
            Console.Write("Введите число (от 1 до 9): ");
            int number = Check.GetValidNumberInput();

            Console.Write("Введите номер строки (от 0 до 2): ");
            int row = GetValidRowInput();

            Console.Write("Введите номер столбца (от 0 до 2): ");
            int col = GetValidColumnInput();

            if (IsValidInput(number, row, col))
            {
                field[row, col] = number;
                usedNumbers[number - 1] = true;
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Попробуйте снова.");
            }
        }

        /// <summary>
        /// Проверка заполнености массива
        /// </summary>
        /// <returns>Заполнен/не заполнен</returns>
        private bool IsFieldFull()
        {
            const int FIELD_SIZE = 3;
            for (int i = 0; i < FIELD_SIZE; i++)
            {
                for (int j = 0; j < FIELD_SIZE; j++)
                {
                    if (field[i, j] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
    
}
