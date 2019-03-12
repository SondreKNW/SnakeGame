using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SnakeGame
{
    class Directions
    {
        public void Show(Border border)
        {
            Clear();
            border.Render();
            ForegroundColor = ConsoleColor.Yellow;
            SetCursorPosition(5, 5);
            WriteLine("1) Use the arrow  keys to move the snake around the field.");
            SetCursorPosition(5, 6);
            WriteLine("2) The snake will die if it runs in to the wall,");
            SetCursorPosition(5, 7);
            WriteLine(" the snake will also die if it hits it self.");
            SetCursorPosition(5, 8);
            WriteLine("3) You gain points by eating berrys,");
            SetCursorPosition(5, 9);
            WriteLine(" but your snake will also go faster and get longer");
            SetCursorPosition(5, 11);
            WriteLine("Press enter to return to the main menu");
            ReadLine();
            Clear();
        }
    }
}
