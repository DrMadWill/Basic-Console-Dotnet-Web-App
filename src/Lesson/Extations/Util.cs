using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson.Extations
{
    public static class Util
    {

        public static bool TryAgen()
        {
            Console.WriteLine("Try Age?");
            Console.Write("(Y/N) => ");
            string isContune = Console.ReadLine();
            if (isContune == "N")
            {
                return true;
            }

            return false;
        }

    }
}
