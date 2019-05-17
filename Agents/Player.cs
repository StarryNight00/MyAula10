using System;
using System.Collections.Generic;
using System.Text;

namespace Agents
{
    class Player : Agent
    {
        public override char Move()
        {
            Console.WriteLine("Which Direction? N, S, W or E");
            char dir = Convert.ToChar(Console.ReadLine());

            return dir;
        }

        public override string ToString()
        {
            return $"I'm a Player and my name is {Name}";
        }
    }
}
