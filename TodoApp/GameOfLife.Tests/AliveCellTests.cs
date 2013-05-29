using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using GameOfLife;

namespace GameOfLife.Tests
{
    [TestFixture]
    public class AliveCellTests : CellTestFixture
    {
        protected override bool StateOfCell
        {
            get
            {
                return Alive;
            }
        }

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
    }
}
