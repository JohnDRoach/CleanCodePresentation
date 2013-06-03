using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using GameOfLife;

namespace GameOfLife.Tests
{
    [TestFixture]
    public class AliveCellTests
    {
        [Test]
        public void CellWithNoNeighboursDies()
        {
            GivenCellWithThisManyNeighbours(0);

            CellIsDead(AfterEvolving());
        }

        [Test]
        public void CellWithOneNeighbourDies()
        {
            GivenCellWithThisManyNeighbours(1);

            CellIsDead(AfterEvolving());
        }

        [Test]
        public void CellWithTwoNeighboursSurvives()
        {
            GivenCellWithThisManyNeighbours(2);

            CellIsAlive(AfterEvolving());
        }

        [Test]
        public void CellWithThreeNeighboursSurvives()
        {
            GivenCellWithThisManyNeighbours(3);

            CellIsAlive(AfterEvolving());
        }

        [Test]
        public void CellWithFourNeighboursDies()
        {
            GivenCellWithThisManyNeighbours(4);

            CellIsDead(AfterEvolving());
        }

        [Test]
        public void CellWithFiveNeighboursDies()
        {
            GivenCellWithThisManyNeighbours(5);

            CellIsDead(AfterEvolving());
        }

        [Test]
        public void CellWithSixNeighboursDies()
        {
            GivenCellWithThisManyNeighbours(6);

            CellIsDead(AfterEvolving());
        }

        [Test]
        public void CellWithSevenNeighboursDies()
        {
            GivenCellWithThisManyNeighbours(7);

            CellIsDead(AfterEvolving());
        }

        [Test]
        public void CellWithEightNeighboursDies()
        {
            GivenCellWithThisManyNeighbours(8);

            CellIsDead(AfterEvolving());
        }



        private IList<Cell> neighbours = new List<Cell>()
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

        private const bool Alive = true;
        private const bool Dead = false;
        private Cell cell = new Cell(1, 1);
        private bool[,] world;

        private void GivenCellWithThisManyNeighbours(int numberOfNeighbours)
        {
            world = new bool[3, 3];
            world[cell.X, cell.Y] = Alive;

            foreach (Cell neighbour in neighbours.Take(numberOfNeighbours))
            {
                world[neighbour.X, neighbour.Y] = Alive;
            }
        }

        private void CellIsAlive(bool value)
        {
            Assert.IsTrue(value);
        }

        private void CellIsDead(bool value)
        {
            Assert.IsFalse(value);
        }

        private bool AfterEvolving()
        {
            return new Incubator(world).Evolve()[cell.X, cell.Y];
        }
    }
}
