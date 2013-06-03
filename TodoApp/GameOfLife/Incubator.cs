using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLife
{
    public class Incubator
    {
        private bool[,] current;

        public Incubator(bool[,] currentWorld)
        {
            current = currentWorld;
        }

        public bool[,] Evolve()
        {
            bool[,] newWorld = new bool[current.GetLength(0), current.GetLength(1)];

            for (int i = 0; i < current.GetLength(0); ++i)
            {
                for (int j = 0; j < current.GetLength(1); ++j)
                {
                    newWorld[i, j] = EvolveCell(i, j);
                }
            }

            return newWorld;
        }

        private bool EvolveCell(int x, int y)
        {
            int aliveNeighbourCount = 0;

            for (int i = x - 1; i <= x + 1; ++i)
            {
                for (int j = y - 1; j <= y + 1; ++j)
                {
                    if (LiesInWorld(i, j) && current[i, j])
                    {
                        if (x != i || y != j)
                        {
                            aliveNeighbourCount++;
                        }
                    }
                }
            }

            switch (aliveNeighbourCount)
            {
                case (0):
                case (1):
                    return false;
                case (2):
                    return current[x, y];
                case (3):
                    return true;
                default:
                    return false;
            }
        }

        private bool LiesInWorld(int x, int y)
        {
            if (x < 0 || y < 0)
            {
                return false;
            }

            if (x >= current.GetLength(0))
            {
                return false;
            }

            if (y >= current.GetLength(1))
            {
                return false;
            }

            return true;
        }
    }
}
