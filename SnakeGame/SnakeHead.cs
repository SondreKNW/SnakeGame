using System;

namespace SnakeGame
{
    partial class Program
    {
        public class SnakeHead
        {
            private readonly Options _options;
            public int XPos { get; set; }
            public int YPos { get; set; }

            public SnakeHead(Options options) 
            {
                XPos = options.BoardWidth / 2;
                YPos = options.BoardHeight / 2;
                _options = options;
            }

            public bool Hits(Border border) => XPos == border.Width || XPos == 0 || YPos == border.Height || YPos == 0;

            public bool Hits(Berry berry) => berry._currentXPosition == XPos && berry._currentYPosition == YPos;

            public void Render()
            {
                Console.SetCursorPosition(XPos, YPos);
                Console.ForegroundColor = _options.HeadColor;
                Console.Write((char)2);
            }
        }
    }
}
