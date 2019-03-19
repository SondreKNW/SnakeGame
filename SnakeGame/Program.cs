using System;
using System.Speech.Synthesis;
using System.Threading;
using static System.Console;

namespace SnakeGame
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var border = new Border();
            var directions = new Directions();

            string userAction = "";

            bool isStayInMenu = true;

            CursorVisible = false;

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

                    case "2":
                    case "p":
                    case "play":
                        new SnakeGame().Play();
                        ShowMenu(out userAction);
                        break;

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

            }
            while (isStayInMenu);
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
    }
}
