using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Options
    {
        public int BoardHeight { get; set; } = 32;

        public int BoardWidth { get; set; } = 64;

        public double gameSpeed = 150;

        public string Block { get; set; } = "■";

        public string SnakeBody { get; set; } = "▲";

        public string Berry { get; set; } = "Ó";

        public string SnakeHead { get; set; } = "♦";

        public ConsoleColor BorderColor { get; set; } = ConsoleColor.DarkMagenta;

        public ConsoleColor BerryColor { get; set; } = ConsoleColor.DarkRed;

        public ConsoleColor BodyColor { get; set; } = ConsoleColor.Green;

        public ConsoleColor BackgroundColor { get; set; } = ConsoleColor.Black;

        public ConsoleColor HeadColor { get; set; } = ConsoleColor.Red;
    }
}
