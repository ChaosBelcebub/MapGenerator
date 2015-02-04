using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapGenerator
{
    class Generator
    {
        public byte[,] generatedMap
        {
            get
            {
                return map;
            } 
        }

        private byte[,] map;

        public Generator()
        {

        }

        /// <summary>
        /// Generate a new map as 2DArray
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        public void generate(int X, int Y)
        {
            
        }
    }
}
