﻿

namespace AppFigures
{
    internal class Intro
    {
        internal void ShowMenu()
        {
            do
            {
                int[] flags = [0, 0, 0, 0];

                ShowIntro();

                flags[0] = Helper.CheckForDigit("1234");

                Figures.RunSelection(flags);

            } while (!HasQuit());
        }

        private static bool HasQuit()
        {
            bool hasQuit = false;

            Console.Write("Davom etish uchun 'x' ni, chiqish uchun 'y' bosing: ");

            if (Helper.CheckForYESorNO("xy") == 1)
            {
                hasQuit = true;
                Console.Clear();
            }

            return hasQuit;
        }

        private static void ShowIntro()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("1. Gorizontal chiziq");
            Console.WriteLine("2. Vertikal chiziq");
            Console.WriteLine("3. Uchburchak.");
            Console.WriteLine("4. To'rtburchak.");

            Console.Write("\n\u001b[3mIltimos, shakl tartib raqamini kiriting\u001b[0m: ");
        }
    }
}
