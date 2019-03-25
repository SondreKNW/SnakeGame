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
            var options = new Options();
            var border = new Border(options);
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
                        directions.Show(border);
                        break;

                    case "2":
                    case "p":
                        new SnakeGame(options).Play();
                        break;

                    case "3":
                    case "e":
                        isStayInMenu = false;
                        break;

                       
                }

            }
            while (isStayInMenu);
        }

        private static void ShowMenu(out string userAction)
        {
            var gameMenu = new GameMenu();
            gameMenu.Render();

            SpeechSynthesizer toSpeak = new SpeechSynthesizer();
            toSpeak.SetOutputToDefaultAudioDevice();
            toSpeak.Speak("The Snake Game!");

            userAction = ReadKey().KeyChar.ToString().ToLower();
        }
    }
}
