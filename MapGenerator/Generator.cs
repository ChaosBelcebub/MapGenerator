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
        private int sizeX;
        private int sizeY;
        private int allCells;
        private int startMountains;

        public Generator(int X, int Y, int amountOfMountains = 1)
        {
            sizeX = X;
            sizeY = Y;
            allCells = sizeX * sizeY;
            startMountains = amountOfMountains;
            map = new byte[sizeX, sizeY];
        }

        /// <summary>
        /// Generate a new map as 2DArray
        /// </summary>
        public void generate()
        {
            
        }
    }
}
