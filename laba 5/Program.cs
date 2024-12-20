using System.Security.Cryptography.X509Certificates;
using System;
using System.ComponentModel.Design;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
namespace laba_5
{


    /// <summary>Основной класс программы</summary>

    internal class Program
    {
        static void Main()
        {
            bool check = false;
            double doubleResponse;
            int[] res = new int[2];
            while (!check)
            {
                Console.WriteLine("Выберите действие");
                Console.WriteLine("Меню:");
                Console.WriteLine("1) Отгадай ответ");
                Console.WriteLine("2) Об авторе");
                Console.WriteLine("3) Сортировка массива");
                Console.WriteLine("4) Магический квадрат");
                Console.WriteLine("5) Выход");
                doubleResponse = Check.DigitCheck();
                switch (doubleResponse)
                {
                    case 1://1111111111111111111111111111111
                        GuessAnswer.Gaming();
                        break;
                    case 2:
                        Author.AuthorInfo();
                        break;
                    case 3:
                        Console.WriteLine("Выберите способ инициализации массива:");
                        Console.WriteLine("1) По умолчанию (длина == 10)");
                        Console.WriteLine("2) Свое значение");
                        int q = Check.IntDigitCheck();
                        int w;
                        Arrays n = new Arrays();
                        while (q != 1 && q != 2)
                        {
                            Console.WriteLine("Введите корректное значение");
                            q = Check.IntDigitCheck();
                        }
                        if (q == 1)
                        {
                            n = new Arrays();
                        }
                        else if (q == 2)
                        {
                            Console.Write("Введите длину массива: ");
                            w = Check.CheckingArrayLength();
                            n = new Arrays(w);
                        }
                        (int Length, int[] array) = n;
                        
                        Console.Write("Ваш массив: ");
                        n.Creating();
                        n.OutPutting();
                        Arrays copiedArr = n.Coping();
                        Console.WriteLine("Сортировка Шелла: ");
                        Stopwatch sw = new Stopwatch();
                        sw.Start();
                        n.ShellSort();
                        n.OutPutting();
                        sw.Stop();
                        Console.Write("Время выполнения сортировки: ");
                        TimeSpan ShellTime = sw.Elapsed;
                        Console.WriteLine(ShellTime);
                        Console.WriteLine("Сортировка вставками: ");
                        sw = new Stopwatch();
                        sw.Start();
                        copiedArr.InsertionSort();
                        n.OutPutting();
                        sw.Stop();
                        Console.Write("Время выполнения сортировки: ");
                        TimeSpan InsertionsTime = sw.Elapsed;
                        Console.WriteLine(InsertionsTime);
                        Console.Write("разница равна - ");
                        Console.WriteLine(ShellTime - InsertionsTime);
                
                        
                        break;
                    case 4:
                        new Game().MagicSquareGame();
                        break;
                    case 5:
                        check = Exit.Exiting();
                        break;

                    default:
                        Console.WriteLine("Укажите правильный ответ");
                        check = false;
                        break;
                }
            }
        } 
    }


    ///  <summary>Класс, отвечающий за угадайку</summary>
    static class GuessAnswer
    {
        ///  <summary> Основной метод угадайки</summary>
        public static void Gaming()
        {
            Console.WriteLine("Вы выбрали 'Отгадай Ответ'");
            double a = 0;
            double b = 0;
            bool w = false;
            double roundedResult = 0;
            while (!w)
            {
                Console.WriteLine("Введите число а:");
                a = Check.DigitCheck();
                Console.WriteLine("Введите число b:");
                b = Check.DigitCheck();
                if (((Math.Pow(Math.Sin(a), 3) - Math.Pow(Math.Cos(b), 2)) != 0) && ((Math.Pow(Math.Sin(a), 2) + Math.Pow(Math.Cos(b), 3)) / (Math.Pow(Math.Sin(a), 3) - Math.Pow(Math.Cos(b), 2)) >= 0))
                {
                    roundedResult = FuncSolver(a, b);
                    w = true;
                }
                else
                {
                    Console.WriteLine("Функция не существует при таких значениях");
                }
            }
            Guessing(roundedResult);
        }
        ///  <summary>Метод, отвечающий за отгадывание ответа</summary>
        public static void Guessing(double correctAnswer)
        {
            int i = 0;
            double userAnswer = 0;
            while (i < 3)
            {
                Console.WriteLine("Введите ваш ответ: ");
                bool k = false;
                while (!k)
                {
                    if (double.TryParse(Console.ReadLine(), out double h))
                    {
                        k = true;
                        userAnswer = h;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели не число");
                    }
                }
                if (userAnswer != correctAnswer)
                {
                    i++;
                    if (i == 1)
                    {
                        Console.WriteLine("Неправильно, попробуйте еще раз\nУ вас осталось 2 попытки");
                    }
                    else if (i == 3)
                    {
                        Console.WriteLine("Неправиьльно");
                    }
                    else if (i == 2)
                    {
                        Console.WriteLine("Неправильно, попробуйте еще раз\nУ вас осталась последняя попытка");
                    }
                }
                else
                {
                    Console.WriteLine("Вы угадали!");
                    i = 3;
                }
                if (i == 3)
                {
                    Console.Write("Правильный ответ:");
                    Console.WriteLine(correctAnswer);
                }
            }
        }
        ///  <summary>Метод, отвечающий за решение функции </summary>
        ///  <param name="a">Значение переменной "a"</param>
        ///  <param name="b">Значение переменной "b"</param>
        ///  <returns>Округленный результат</returns>
        public static double FuncSolver(double a, double b)
        {
            double result = 0;
            double roundedResult = 0;
            result = Math.Sqrt((Math.Pow(Math.Sin(a), 2) + Math.Pow(Math.Cos(b), 3)) / (Math.Pow(Math.Sin(a), 3) - Math.Pow(Math.Cos(b), 2)));
            roundedResult = Math.Round(result, 2);
            return roundedResult;
        }
    }


    ///  <summary>Класс, содержащий методы для проверки вводимых данных </summary>
    public static class Check
    {
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
        public static int IntDigitCheck()
        {
            int l = 0;
            int u = 0;
            bool t = false;
            while (!t)
            {
                t = int.TryParse(Console.ReadLine(), out l);
                if (!t)
                    Console.WriteLine("Вы ввели не число. Введите число");
                else
                {
                    u = l;
                }
            }
            return u;
        }

        ///  <summary>Проверка значения длины массива</summary>
        ///  <returns>Длина массива, если введенное значение больше 0</returns>
        public static int CheckingArrayLength()
        {
            int n;
            n = IntDigitCheck();
            while (n <= 0)
            {
                Console.WriteLine("Длина массива должна быть больше 0");
                Console.WriteLine("Введите длину массива");
                n = IntDigitCheck();
            }
            return n;
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

    /// <summary>Класс, отвечающий за работу с массивами</summary>
    public class Arrays
    {
        private int length = 10;
        private int[] array;
        
        /// <summary>Конструктор с параметром</summary>
        public Arrays(int lenghtValue)
        {
            length = lenghtValue;
            array = new int[length];
        }

        /// <summary>Конструктор без параметров</summary>
        public Arrays()
        {
            array = new int[10];
            length = 10;
        }
        
        public void Deconstruct(out int lenghtValue, out int[] arrayValue)
        {
            lenghtValue = length;
            arrayValue = array;

        }







        /// <summary>Создание и заполнение массива рандомными значениями</summary>
        public void Creating()
        {
            
            Random rand = new Random();
            for (int i = 0; i < this.length; i++)
            {
                this.array[i] = rand.Next(-100, 100);
            }
            
        }
        /// <summary>Вывод массива в консоль</summary>
        public void OutPutting()
        {
            int d = this.length;
            if (d > 10)
            {
                Console.WriteLine("Длина массива больше 10. Вывести массив на экран невозможно!");
            }
            else
            {
                for (int i = 0; i < this.length; i++)
                {
                    Console.Write(this.array[i] + " ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>Метод для копирования массива</summary>
        /// <param name="n">Массив целых чисел</param>
        /// <returns>Скопированный массив</returns>
        public Arrays Coping()
        {
            Arrays copied = new Arrays(this.length);
            return copied;
        }

        
        /// <summary>Сортировка Шелла</summary>
        /// <param name="n">Массив целых чисел</param>
        /// <returns>Массив, после сортировки Шелла</returns>
        public void ShellSort()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int d = this.length;
            for (int gap = d / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < d; i++)
                {
                    int temp = this.array[i];
                    int j;
                    for (j = i; j >= gap && this.array[j - gap] > temp; j -= gap)
                    {
                        this.array[j] = this.array[j - gap];
                    }
                    this.array[j] = temp;
                }
            }
            sw.Stop();
            
        }

        /// <summary>Сортировка вставками</summary>
        /// <param name="n">Массив целых чисел</param>
        /// <returns>Массив, после сортировки вставками</returns>
        public  void InsertionSort()
        {
            var sw = new Stopwatch();
            sw.Start();
            int d = this.length;
            for (int i = 1; i < d; i++)
            {
                int key = this.array[i];
                int j = i - 1;
                while (j >= 0 && this.array[j] > key)
                {
                    this.array[j + 1] = this.array[j];
                    j--;
                }
                this.array[j + 1] = key;
            }
            sw.Stop();
            TimeSpan insertionTime = sw.Elapsed;
            
        }
    }

    /// <summary>
    /// Класс, отвечающий за игру в магический квадрат
    /// </summary>
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
        private int GetRowSum(int row)
        {
            int sum = 0;
            for (int j = 0; j < FIELD_SIZE; j++)
            {
                sum += field[row, j];
            }
            return sum;
        }

        /// <summary>
        /// Получение суммы всех элементов столбца
        /// </summary>
        /// <param name="col">номер столбца</param>
        /// <returns>Сумму столбца</returns>
        private int GetColumnSum(int col)
        {
            int sum = 0;
            for (int i = 0; i < FIELD_SIZE; i++)
            {
                sum += field[i, col];
            }
            return sum;
        }
        /// <summary>
        /// Получение суммы всех элементов в диагонали
        /// </summary>
        /// <param name="row">номер строки</param>
        /// <param name="col">номер столбца</param>
        /// <returns>Сумму диагонали</returns>
        private int GetDiagonalSum(int row, int col)
        {

            int sum = 0;
            int i = row;
            int j = col;
            while (i >= 0 && i < FIELD_SIZE && j >= 0 && j < FIELD_SIZE)
            {
                sum += field[i, j];
                i += 1;
                j += (col == 0) ? 1 : -1;
            }
            return sum;
        }

        /// <summary>
        /// Проверка поля на соответствие условиям магического квадрата
        /// </summary>
        /// <returns>Соответствует/ не соответствует</returns>
        private bool IsMagicSquare()
        {
            for (int i = 0; i < FIELD_SIZE; i++)
            {
                if (GetRowSum(i) != 15 || GetColumnSum(i) != 15)
                {
                    return false;
                }
            }
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