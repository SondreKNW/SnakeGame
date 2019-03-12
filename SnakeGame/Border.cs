using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Border
    {
        private readonly Options _options;

        public Border(Options options)
        {
            _options = options;
        }

        public int Width => _options.BoardWidth - 1;

        public int Height => _options.BoardHeight - 1;

        public void Render()
        {
            Console.ForegroundColor = _options.BorderColor;
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write(_options.Block);

                Console.SetCursorPosition(i, Console.WindowHeight - 1);
                Console.Write(_options.Block);
            }

            for (int i = 0; i < Console.WindowHeight; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(_options.Block);

                Console.SetCursorPosition(Console.WindowWidth - 1, i);
                Console.Write(_options.Block);
            } 
        }
    }
}



