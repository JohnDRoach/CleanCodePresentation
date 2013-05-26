using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLife
{
    public class GameBoard
    {
        private const int XSIZE = 9;
        private const int YSIZE = 9;
        private bool[,] world;

        public GameBoard() : this(new List<Cell>())
        {
        }

        // cells contains only the alive cells
        public GameBoard(IEnumerable<Cell> cells)
        {
            world = new bool[XSIZE,YSIZE];
            
            for (int i = 0; i < XSIZE; ++i)
            {
                for (int j = 0; j < YSIZE; ++j)
                {
                    world[i,j] = false;
                }
            }

            foreach (Cell cell in cells)
            {
                // True meaning that the cell is alive
                world[cell.X, cell.Y] = true;
            }
        }

        public void Evolve()
        {
            var thing = new Incubator(world);
            world = thing.Evolve();
        }

        public bool[,] World
        {
            get
            {
                return world;
            }
        }

        public string ScreenFriendlyWorld()
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < XSIZE; ++i)
            {
                for (int j = 0; j < YSIZE; ++j)
                {
                    if (world[i, j])
                    {
                        builder.Append("X");
                    }
                    else
                    {
                        builder.Append(" ");
                    }
                }

                builder.AppendLine();
            }

            return builder.ToString();
        }
    }
}
