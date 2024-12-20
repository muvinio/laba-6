using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_5
{
    internal class Exit
    {
        public static bool Exiting()
        {
            int[] res = new int[2];
            Console.WriteLine("Уверенны, что хотите выйти (д/н)");
            string exitCheck = Console.ReadLine();

            while (exitCheck != "д" && exitCheck != "н")
            {
                Console.WriteLine("Введите д/н");
                exitCheck = Console.ReadLine();
            }

            if (exitCheck == "д")
            {
                Console.WriteLine("Вы вышли из программы");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
