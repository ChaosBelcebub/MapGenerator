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

        Random rnd = new Random();

        public Generator(int X, int Y, float percentageOfMountains = 0.1f)
        {
            sizeX = X;
            sizeY = Y;
            allCells = sizeX * sizeY;
            startMountains = (int)(allCells * percentageOfMountains);
            map = new byte[sizeX, sizeY];
        }

        /// <summary>
        /// Generate a new map as 2DArray
        /// </summary>
        public void generate()
        {
            
        }

        /// <summary>
        /// Set the first cells at the given percentage
        /// </summary>
        private void setFirstCells()
        {
            //add random heights to all the wanted cells
            for (int i = 0; i < startMountains; i++)
            {
                map[(int)rnd.Next(sizeX), (int)rnd.Next(sizeY)] = (byte)rnd.Next(255);
            }
        }
    }
}
