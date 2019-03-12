using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class SnakeBody
    {
        private readonly Options _options;

        public SnakeBody(Options options)
        {
            int[] xPos = new int[50];
            xPos[0] = 35;
            int[] yPos = new int[50];
            yPos[0] = 20;

            _options = options;
            Render(BerrysEaten, xPos, yPos, out xPos, out yPos);
        }

        public int BerrysEaten { get; }

        public void Render(int berrysEaten, int[] xPosIn, int[] yPosIn, out int[] xPosOut, out int[] yPosOut)
        {
            for (int i = 1; i < berrysEaten + 1; i++)
            {
                Console.SetCursorPosition(xPosIn[0], yPosIn[0]);
                Console.ForegroundColor = _options.BodyColor;
                Console.WriteLine(_options.Block);
            }

            Console.SetCursorPosition(xPosIn[berrysEaten + 1], yPosIn[berrysEaten + 1]);
            Console.WriteLine(" ");

            for (int i = berrysEaten; i < 0; i--)
            {
                xPosIn[i] = xPosIn[i - 1];
                yPosIn[i] = yPosIn[i - 1];
            }

            xPosOut = xPosIn;
            yPosOut = yPosIn;
        }
    }
}
