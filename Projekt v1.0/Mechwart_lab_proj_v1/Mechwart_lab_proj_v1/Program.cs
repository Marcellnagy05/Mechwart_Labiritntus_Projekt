using System;

namespace Mechwart_lab_proj_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            char character = '#';
            char Pressed = Console.ReadKey().KeyChar;
            Console.CursorVisible = false;
            do
            {
                Console.SetCursorPosition(x, y);
                Console.Write('#');
                if (Console.KeyAvailable)
                {
                //    var Pressed = Console.ReadKey().Key;

                //    switch (Pressed)
                //    {
                //        case 1:
                //            {
                //                Console.ReadKey().Key == ConsoleKey.UpArrow

                //    }
                //    }
                //}
                //if (Pressed == 'w')
                //{

                //    //(ENG)Places down a new character; (HUN)Lerakja az új karaktert
                //    y--;
                //    Console.SetCursorPosition(x, y);
                //    Console.Write(character);

                //    //(ENG)Erase previous character; (HUN)Kitörli az előző karaktert
                //    Console.SetCursorPosition(x, y + 1);
                //    Console.Write(' ');
                //    Console.SetCursorPosition(x + 1, y + 1);
                //    Console.Write(' ');

                //}
                //else if (Pressed == 's')
                //{

                //    //(ENG)Places down a new character; (HUN)Lerakja az új karaktert
                //    y++;
                //    Console.SetCursorPosition(x, y);
                //    Console.Write(character);

                //    //(ENG)Erase previous character; (HUN)Kitörli az előző karaktert
                //    Console.SetCursorPosition(x, y - 1);
                //    Console.Write(' ');
                //    Console.SetCursorPosition(x + 1, y - 1);
                //    Console.Write('*');

                //}
                //else if (Pressed == 'd')
                //{

                //    //(ENG)Places down a new character; (HUN)Lerakja az új karaktert
                //    x++;
                //    Console.SetCursorPosition(x, y);
                //    Console.Write(character);

                //    //(ENG)Erase previous character; (HUN)Kitörli az előző karaktert
                //    Console.SetCursorPosition(x - 1, y);
                //    Console.Write(' ');
                //    Console.SetCursorPosition(x + 1, y);
                //    Console.Write('*');

                //}
                //else if (Pressed == 'a')
                //{

                //    //(ENG)Places down a new character; (HUN)Lerakja az új karaktert
                //    x--;
                //    Console.SetCursorPosition(x, y);
                //    Console.Write(character);

                //    //(ENG)Erase previous character; (HUN)Kitörli az előző karaktert
                //    Console.SetCursorPosition(x + 1, y);
                //    Console.Write(' ');
                //    Console.SetCursorPosition(x + 2, y);
                //    Console.Write('*');

                //    //(ENG)wall mechanic; (HUN)Fal mechanika 
                //    //if ( )
                //    //{

                //    //}
                //}
            } while (Pressed != 'e');

        }
    }
}
