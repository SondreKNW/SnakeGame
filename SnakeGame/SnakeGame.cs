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
        private readonly Options _options = new Options();
        private readonly Border _border = new Border();
        private readonly Program.SnakeHead _snakeHead = new Program.SnakeHead();
        private readonly Berry _berry = new Berry();
        private readonly GameBorder _gameBorder = new GameBorder();
        private readonly SnakeBody _snakeBody = new SnakeBody();
        private readonly Directions _directions = new Directions();

        private double gameSpeed = 150;

        private int BerrysEaten = 0;

        private bool gameover = false;
        
        public SnakeGame()
        {
        }

        public void Play()
            {
            var xPosBody = new List<int>();
            var yPosBody = new List<int>();

            var currentMovement = Movement.Right;

            while (true)
               {            
                    _gameBorder.Clear(_options);
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
                    Write(_options.SnakeBody);
                        if (xPosBody[i] == _snakeHead.XPos && yPosBody[i] == _snakeHead.YPos)
                        {
                            gameover = true;
                        }
                    }

                    // How often the game checks movement
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
                    
                    // Creates the "Game Over" screen
                    if (gameover)
                    {                   
                    SetCursorPosition(_options.BoardWidth / 13, _options.BoardHeight / 2);
                    WriteLine("Game over, the snake had an accident. Your score is: " + BerrysEaten * 100);
                    SetCursorPosition(_options.BoardWidth / 13, _options.BoardHeight / 2 + 1);
                    WriteLine("Press enter to continue.");
                    ReadLine();
                    BerrysEaten = 0;
                    Clear();
                    return;
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
