using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class GameBorder
    {
        private readonly Options _options;

        public GameBorder(Options options)
        {
            _options = options;
            Console.WindowHeight = _options.BoardHeight;
            Console.WindowWidth = _options.BoardWidth;
        }

        public void Clear(Options options)
        {
            var blackLine = new string(' ', options.BoardWidth - 2);
            Console.ForegroundColor = options.BackgroundColor;
            for (int i = 1; i < options.BoardHeight - 1; i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write(blackLine);
            }
        }
    }
}
