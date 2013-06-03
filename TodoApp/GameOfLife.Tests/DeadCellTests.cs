using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using GameOfLife;

namespace GameOfLife.Tests
{
    [TestFixture]
    public class DeadCellTests : CellTestFixture
    {
        protected override bool StateOfCell
        {
            get
            {
                return Dead;
            }
        }

        [Test]
        public void CellWithNoNeighboursStaysDead()
        {
            GivenCellWithThisManyNeighbours(0);

            CellIsDead(AfterEvolving());
        }

        [Test]
        public void CellWithOneNeighbourStaysDead()
        {
            GivenCellWithThisManyNeighbours(1);

            CellIsDead(AfterEvolving());
        }

        [Test]
        public void CellWithTwoNeighboursStaysDead()
        {
            GivenCellWithThisManyNeighbours(2);

            CellIsDead(AfterEvolving());
        }

        [Test]
        public void CellWithThreeNeighboursIsReborn()
        {
            GivenCellWithThisManyNeighbours(3);

            CellIsAlive(AfterEvolving());
        }

        [Test]
        public void CellWithFourNeighboursStaysDead()
        {
            GivenCellWithThisManyNeighbours(4);

            CellIsDead(AfterEvolving());
        }

        [Test]
        public void CellWithFiveNeighboursStaysDead()
        {
            GivenCellWithThisManyNeighbours(5);

            CellIsDead(AfterEvolving());
        }

        [Test]
        public void CellWithSixNeighboursStaysDead()
        {
            GivenCellWithThisManyNeighbours(6);

            CellIsDead(AfterEvolving());
        }

        [Test]
        public void CellWithSevenNeighboursStaysDead()
        {
            GivenCellWithThisManyNeighbours(7);

            CellIsDead(AfterEvolving());
        }

        [Test]
        public void CellWithEightNeighboursStaysDead()
        {
            GivenCellWithThisManyNeighbours(8);

            CellIsDead(AfterEvolving());
        }
    }
}
