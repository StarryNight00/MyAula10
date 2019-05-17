using System;
using System.Collections.Generic;
using System.Text;

namespace Agents
{
    class Player : Agent
    {
        public Player(string name) : base(name) { }

        public override char Move()
        {
            Console.WriteLine("Which Direction? N, S, W or E");
            char dir = Convert.ToChar(Console.ReadLine());

            return dir;

            /* Sem variáveis
             * 
             * Console.Write("Direção: ");
             * return Console.ReadLine().ToUpper()[0];
             * 
             */
        }

        public override string ToString() => $"I'm a Player and my name is {Name}";
    }
}
