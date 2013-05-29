using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace GameOfLife.Tests
{
    public abstract class CellTestFixture
    {
        protected const bool Alive = true;
        protected const bool Dead = false;
        protected abstract bool StateOfCell { get; }

        protected IList<Cell> neighbours = new List<Cell>()
        {
            new Cell(0,0),
            new Cell(0,1),
            new Cell(0,2),
            new Cell(1,0),
            new Cell(1,2),
            new Cell(2,0),
            new Cell(2,1),
            new Cell(2,2)
        };

        protected Cell cell = new Cell(1, 1);
        protected bool[,] world;

        protected void GivenCellWithThisManyNeighbours(int numberOfNeighbours)
        {
            world = new bool[3, 3];
            world[cell.X, cell.Y] = StateOfCell;

            foreach (Cell neighbour in neighbours.Take(numberOfNeighbours))
            {
                world[neighbour.X, neighbour.Y] = true;
            }
        }

        protected void CellIsAlive(bool value)
        {
            Assert.IsTrue(value);
        }

        protected void CellIsDead(bool value)
        {
            Assert.IsFalse(value);
        }

        protected bool AfterEvolving()
        {
            return new Incubator(world).Evolve()[cell.X, cell.Y];
        }
    }
}
