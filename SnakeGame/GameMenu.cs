using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Threading;

namespace SnakeGame
{
    class GameMenu
    {
        public GameMenu()
        {
        }

        public void Render()
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
        }
    }
}

