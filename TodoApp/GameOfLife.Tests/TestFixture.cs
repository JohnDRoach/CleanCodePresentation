using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using GameOfLife;

namespace GameOfLife.Tests
{
    [TestFixture]
    public class TestFixture1
    {
        [Test]
        public void CellWithOneNeighbourDies()
        {
            bool[,] world = new bool[3, 3];
            world[1, 1] = true;
            world[0, 0] = true;

            Assert.IsFalse(new Incubator(world).Evolve()[1,1]);
        }
    }
}
