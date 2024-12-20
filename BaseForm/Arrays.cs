using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace windowsForm
{
    
        public class Arrays
        {
            public int length = 10;
            public int[] array;

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
                SortingArraysForm sortingArraysForm = new SortingArraysForm();
                int d = this.length;
                if (d > 10)
                {
                    
                    sortingArraysForm.ConsoleBox.Text = ("Длина массива больше 10. Вывести массив на экран невозможно!");
                }
                else
                {
                    for (int i = 0; i < this.length; i++)
                    {
                        sortingArraysForm.ConsoleBox.Text += (this.array[i] + " ");
                    }
                    
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
            public void InsertionSort()
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
    
}
