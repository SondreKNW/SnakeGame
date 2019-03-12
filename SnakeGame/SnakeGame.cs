using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Diagnostics;

namespace SnakeGame
{
    class SnakeGame
    {
        public SnakeGame()
        {
            var _options = new Options();
            var _border = new Border(_options);
            var _snakeHead = new Program.SnakeHead(_options);
            var _berry = new Berry(_options);
            var _gameborder = new GameBorder(_options);
            var _snakeBody = new SnakeBody(_options);
            var _directions = new Directions();

            int BerrysEaten = 0;

            double gameSpeed = 150;

            var gameover = false;

            var xPosBody = new List<int>();
            var yPosBody = new List<int>();

            var currentMovement = Movement.Right;

            void Render()
            {
                while (true)
                {
                    _gameborder.Clear(_options);
                    _border.Render();
                    _berry.Render();
                    _snakeHead.Render();

                    if (_snakeHead.Hits(_border))
                    {
                        gameover = true;
                        SetCursorPosition(28, 20);
                    }

                    ForegroundColor = _options.BodyColor;
                    if (_snakeHead.Hits(_berry))
                    {
                        BerrysEaten++;
                        _berry.PutBerryAtRandomPosition();
                        gameSpeed *= 0.925;
                    }

                    for (int i = 0; i < xPosBody.Count(); i++)
                    {
                        SetCursorPosition(xPosBody[i], yPosBody[i]);
                        Write(_options.Block);
                        if (xPosBody[i] == _snakeHead.XPos && yPosBody[i] == _snakeHead.YPos)
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
                    xPosBody.Add(_snakeHead.XPos);
                    yPosBody.Add(_snakeHead.YPos);

                    // Move head to the next position
                    switch (currentMovement)
                    {
                        case Movement.Up:
                            _snakeHead.YPos--;
                            break;
                        case Movement.Down:
                            _snakeHead.YPos++;
                            break;
                        case Movement.Left:
                            _snakeHead.XPos--;
                            break;
                        case Movement.Right:
                            _snakeHead.XPos++;
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
                        SetCursorPosition(_options.BoardWidth / 2, _options.BoardHeight / 2);
                        WriteLine("Game over, the snake had an accident. Your score is: " + BerrysEaten * 100);
                        SetCursorPosition(_options.BoardWidth / 2, _options.BoardHeight / 2 + 1);
                        WriteLine("Press enter to continue.");
                        BerrysEaten = 0;
                        ReadLine();
                        Clear();
                    }
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
