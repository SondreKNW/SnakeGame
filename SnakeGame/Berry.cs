using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Berry
    {
        private Random _randomizer = new Random();
        private readonly Options _options = new Options();
        public int _currentXPosition;
        public int _currentYPosition;

        public Berry()
        {
            PutBerryAtRandomPosition();
        }

        public void PutBerryAtRandomPosition()
        {
            _currentXPosition = _randomizer.Next(1, _options.BoardWidth -1);
            _currentYPosition = _randomizer.Next(1, _options.BoardHeight -1);
        }

        public void Render()
        {
            Console.SetCursorPosition(_currentXPosition, _currentYPosition);
            Console.ForegroundColor = _options.BerryColor;
            Console.Write(_options.Block);
        }
    }
}
