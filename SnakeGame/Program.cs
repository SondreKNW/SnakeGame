using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
using System.Diagnostics;
using System.Speech.Synthesis;

namespace SnakeGame
{
    partial class Program
    {
        static void Main(string[] args)
        {
            #region Vars
            var options = new Options();
            var border = new Border(options);
            var snakeHead = new SnakeHead(options);
            var berry = new Berry(options);
            var gameborder = new GameBorder(options);
            var snakeBody = new SnakeBody(options);
            var directions = new Directions();
            var snakegame = new SnakeGame();

            //var gameover = false;
            //double gameSpeed = 150;

            var xPosBody = new List<int>();
            var yPosBody = new List<int>();

            string userAction = "";

            bool isStayInMenu = true;

            //int BerrysEaten = 0;

            Console.CursorVisible = false;

            #endregion

            do
            {
                ShowMenu(out userAction);
            

            
            switch (userAction)
            {
                case "1":
                case "d":
                case "directions":
                    directions.Show(border);
                    ShowMenu(out userAction);
                    break;

                #region Case Play
                case "2":
                case "p":
                case "play":
                        Clear();
                        #region Game Setup
                        

                        /*
                          // Starts SnakeHead moving to the right of the console
                        var currentMovement = Movement.Right;

                        while (true)
                        {
                            gameborder.Clear(options);
                            border.Render();
                            berry.Render();
                            snakeHead.Render();
                            #endregion

                            #region Gameplay
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
                                SetCursorPosition(options.BoardWidth / 2, options.BoardHeight / 2);
                                WriteLine("Game over, Score: " + BerrysEaten * 100);
                                SetCursorPosition(options.BoardWidth / 2, options.BoardHeight / 2 + 1);
                                WriteLine("Press enter to continue.");
                                BerrysEaten = 0;
                                ReadLine();
                                Clear();
                                ShowMenu(out userAction); 
                            }
                       }         
                        */
                        Clear();
                        ShowMenu(out userAction);
                    #endregion

                    #endregion

                    case "3":
                case "e":
                case "exit":
                    isStayInMenu = false;
                    Clear();
                        Environment.Exit(0);
                    break;

                default:
                    WriteLine("Your input was not understood, press enter and try again.");
                    ReadLine();
                    Clear();
                    ShowMenu(out userAction);
                    break;
            }

            } while (isStayInMenu);
        }

        #region Menu
        private static void ShowMenu(out string userAction)
        {
            string menu1 = "1) Directions\n2) Play\n3) Exit \n\n\n" + @"



                                    
                
   _________         _________
  /         \       /         \   
 /  /~~~~~\  \     /  /~~~~~\  \  
 |  |     |  |     |  |     |  |
 |  |     |  |     |  |     |  |
 |  |     |  |     |  |     |  |         /
 |  |     |  |     |  |     |  |       //
(o  o)    \  \_____/  /     \  \_____/ /
 \__/      \         /       \        /
  |         ~~~~~~~~~         ~~~~~~~~
  ^";
            string menu2 = "1) Directions\n2) Play\n3) Exit \n\n\n" + @"



   _________         _________
  /         \       /         \   
 /  /~~~~~\  \     /  /~~~~~\  \  
 |  |     |  |     |  |     |  |
 |  |     |  |     |  |     |  |
 |  |     |  |     |  |     |  |         /
 |  |     |  |     |  |     |  |       //
(o  o)    \  \_____/  /     \  \_____/ /
 \__/      \         /       \        /
  |         ~~~~~~~~~         ~~~~~~~~
  ^";
            string menu3 = "1) Directions\n2) Play\n3) Exit \n\n\n" + @"


   _________         _________
  /         \       /         \   
 /  /~~~~~\  \     /  /~~~~~\  \  
 |  |     |  |     |  |     |  |
 |  |     |  |     |  |     |  |
 |  |     |  |     |  |     |  |         /
 |  |     |  |     |  |     |  |       //
(o  o)    \  \_____/  /     \  \_____/ /
 \__/      \         /       \        /
  |         ~~~~~~~~~         ~~~~~~~~
  ^";
            string menu4 = "1) Directions\n2) Play\n3) Exit \n\n\n" + @"

   _________         _________
  /         \       /         \   
 /  /~~~~~\  \     /  /~~~~~\  \  
 |  |     |  |     |  |     |  |
 |  |     |  |     |  |     |  |
 |  |     |  |     |  |     |  |         /
 |  |     |  |     |  |     |  |       //
(o  o)    \  \_____/  /     \  \_____/ /
 \__/      \         /       \        /
  |         ~~~~~~~~~         ~~~~~~~~
  ^";
            string menu5 = "1) Directions\n2) Play\n3) Exit \n\n\n" + @"
   _________         _________
  /         \       /         \   
 /  /~~~~~\  \     /  /~~~~~\  \  
 |  |     |  |     |  |     |  |
 |  |     |  |     |  |     |  |
 |  |     |  |     |  |     |  |         /
 |  |     |  |     |  |     |  |       //
(o  o)    \  \_____/  /     \  \_____/ /
 \__/      \         /       \        /
  |         ~~~~~~~~~         ~~~~~~~~
  ^";
            ForegroundColor = ConsoleColor.Yellow; 
            WriteLine(menu1);
            Thread.Sleep(100);
            Clear();
            WriteLine(menu2);
            Thread.Sleep(100);
            Clear();
            WriteLine(menu3);
            Thread.Sleep(100);
            Clear();
            WriteLine(menu4);
            Thread.Sleep(100);
            Clear();
            WriteLine(menu5);
            Thread.Sleep(100);

            SpeechSynthesizer toSpeak = new SpeechSynthesizer();
            toSpeak.SetOutputToDefaultAudioDevice();
            toSpeak.Speak("The Snake Game!");

            userAction = ReadLine().ToLower();
        }
        #endregion

        #region Movement Reader

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
        #endregion 
    }
}
