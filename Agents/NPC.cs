using System;
using System.Collections.Generic;
using System.Text;

namespace Agents
{
    class NPC : Agent
    {
        private Random rnd;
        //possivel ser string em vez de char
        private readonly char[] direction;

        public NPC()
        {
            //variante string: direction = "NSWE";
            direction = new char[] { 'N', 'S', 'W', 'E' };
            rnd = new Random();
        }

        public override char Move()
        { 
            int i = rnd.Next(4);

            return direction[i];
        }

        public override string ToString() => $"I'm an NPC and my name is {Name}";
    }
}
