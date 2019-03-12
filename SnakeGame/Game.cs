using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
using System.Diagnostics;

namespace SnakeGame
{
    class Game
    {
        public Game(Options options, Berry berry, Border border, GameBorder gameBorder, Movement movement, )
        {
            var gameover = false;
            var xPosBody = new List<int>();
            var yPosBody = new List<int>();

            double gameSpeed = 150;

            int BerrysEaten = 0;

            var currentMovement = Movement.Right;

            while (true)
            {
                gameborder.Clear(options);
                border.Render();
                berry.Render();
                snakeHead.Render();

                if (snakeHead.Hits(border))
                {
                    gameover = true;
                    SetCursorPosition(28, 20);
                }

                Console.ForegroundColor = options.BodyColor;
                if (snakeHead.Hits(berry))
                {
                    BerrysEaten++;
                    berry.PutBerryAtRandomPosition();
                    gameSpeed *= 0.925;
                }

                for (int i = 0; i < xPosBody.Count(); i++)
                {
                    Console.SetCursorPosition(xPosBody[i], yPosBody[i]);
                    Console.Write(options.Block);
                    if (xPosBody[i] == snakeHead.XPos && yPosBody[i] == snakeHead.YPos)
                    {
                        gameover = true;
                    }
                }



                var sw = Stopwatch.StartNew();
                while (sw.ElapsedMilliseconds <= gameSpeed)
                {
                    currentMovement = ReadMovement(currentMovement);
                }

                // Assign the current head position to the body
                xPosBody.Add(snakeHead.XPos);
                yPosBody.Add(snakeHead.YPos);

                // Move head to the next position
                switch (currentMovement)
                {
                    case Movement.Up:
                        snakeHead.YPos--;
                        break;
                    case Movement.Down:
                        snakeHead.YPos++;
                        break;
                    case Movement.Left:
                        snakeHead.XPos--;
                        break;
                    case Movement.Right:
                        snakeHead.XPos++;
                        break;
                }

                if (xPosBody.Count() > BerrysEaten)
                {
                    xPosBody.RemoveAt(0);
                    yPosBody.RemoveAt(0);
                }

                if (gameover)
                {
                    // Game over screen, shows score based on the lenght of your snake
                    SetCursorPosition(options.BoardWidth / 5, options.BoardHeight / 2);
                    WriteLine("Game over, Score: " + BerrysEaten);
                    SetCursorPosition(options.BoardWidth / 5, options.BoardHeight / 2 + 1);
                    WriteLine("Press enter to continue.");
                    BerrysEaten = 0;
                    ReadLine();
                    Clear();
                    ShowMenu(out userAction);
                }

            }
        }

        // Checks arrowkeys for movement and stops you from walking into your back
        private static Movement ReadMovement(Movement movement)
        {
            if (KeyAvailable)
            {
                var key = ReadKey(true).Key;

                if (key == ConsoleKey.UpArrow && movement != Movement.Down)
                {
                    movement = Movement.Up;
                }
                else if (key == ConsoleKey.DownArrow && movement != Movement.Up)
                {
                    movement = Movement.Down;
                }
                else if (key == ConsoleKey.LeftArrow && movement != Movement.Right)
                {
                    movement = Movement.Left;
                }
                else if (key == ConsoleKey.RightArrow && movement != Movement.Left)
                {
                    movement = Movement.Right;
                }
            }
            return movement;
        }
    }
}
