using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Body
    {
        private readonly Options _options;
        

        public Body(Options options)
        {
            var xPosBody = new List<int>();
            var yPosBody = new List<int>();
            
            for (int i = 0; i < xPosBody.Count(); i++)
            {
                Console.SetCursorPosition(xPosBody[i], yPosBody[i]);
                Console.Write(options.Block);
            }
            if (xPosBody.Count() > options.Score)
            {
                xPosBody.RemoveAt(0);
                yPosBody.RemoveAt(0);
            }
            _options = options;
        }

        public void Render()
        {
        
            Console.ForegroundColor = _options.BodyColor;
        }


    }
}
