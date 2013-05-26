using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameOfLife;

namespace LifeOfGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cell> cells = new List<Cell>();

            foreach (string arg in args)
            {
                string[] stuff = arg.Split(',');
                if (stuff.Length == 2)
                    cells.Add(new Cell(int.Parse(stuff[0]), int.Parse(stuff[1])));
            }

            GameBoard board = new GameBoard(cells);

            PrintWorld(board);

            while (Console.ReadKey().Key.Equals(ConsoleKey.Spacebar))
            {
                board.Evolve();
                PrintWorld(board);
            }
        }

        static void PrintWorld(GameBoard board)
        {
            Console.Out.WriteLine(board.ScreenFriendlyWorld());
            Console.Out.WriteLine("---------");
        }
    }
}
