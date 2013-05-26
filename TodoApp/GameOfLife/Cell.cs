using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLife
{
    public class Cell
    {
        private int x;
        private int y;
        private bool alive;

        public Cell(int x, int y, bool alive = true)
        {
            this.x = x;
            this.y = y;
            this.alive = alive;
        }

        public int X
        {
            get
            {
                return x;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
        }

        public bool IsAlive
        {
            get
            {
                return alive;
            }
        }
    }
}
