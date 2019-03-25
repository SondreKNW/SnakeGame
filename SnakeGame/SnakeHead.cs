using System;

namespace SnakeGame
{
    public class SnakeHead
    {
        public int XPos { get; set; }
        public int YPos { get; set; }
        private readonly Options _options;

        public SnakeHead(Options options)
        {
            XPos = _options.BoardWidth / 2;
            YPos = _options.BoardHeight / 2;
            _options = options;
        }

        public bool Hits(Border border) => XPos == border.Width || XPos == 0 || YPos == border.Height || YPos == 0;

        public bool Hits(Berry berry) => berry._currentXPosition == XPos && berry._currentYPosition == YPos;

        public void Render()
        {
            Console.SetCursorPosition(XPos, YPos);
            Console.ForegroundColor = _options.HeadColor;
            Console.Write(_options.SnakeHead);
        }
    }
}
