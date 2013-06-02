using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TodoApp
{
    public class Compritler
    {
        private UrlReader thing;
        private List<bool> buffer;
        private int counter = 0;

        public Compritler(string source)
        {
            buffer = new List<bool>();
            thing = new UrlReader(source);
        }

        public void Compile()
        {
            buffer.Clear();
            counter = 0;

            string[] next = thing.GetNextToken();

            foreach (string value in next)
            {
                counter++;

                if (value == "True")
                    buffer.Add(true);
                else
                    buffer.Add(false);
            }
        }

        public void Print()
        {
            if (buffer.Count < 7)
            {
                throw new Exception("Not enough tokens for a complete set");
            }

            Console.Out.WriteLine("Time ok? - " + buffer[0]);
            Console.Out.WriteLine("Date ok? - " + buffer[1]);
            Console.Out.WriteLine("Zone ok? - " + buffer[2]);
            Console.Out.WriteLine("Path ok? - " + buffer[3]);
            Console.Out.WriteLine("Map ok? - " + buffer[4]);
            Console.Out.WriteLine("Passengers ok? - " + buffer[5]);
            Console.Out.WriteLine("Run ok? - " + buffer[6]);

            buffer.Clear();
            counter = 0;
        }
    }

    public class UrlReader
    {
        public UrlReader(string blah)
        {
        }

        public string[] GetNextToken()
        {
            return null;
        }
    }
}
