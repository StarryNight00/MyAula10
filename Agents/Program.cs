using System;

namespace Agents
{
    class Program
    {
        static void Main(string[] args)
        {
            Agent[] agents = new Agent[] { new NPC("Huguinho"), new NPC("Zézinho"), new Player("Luisinho") };

            foreach (Agent a in agents)
                Console.WriteLine(a + " and my movement is " + a.Move());

            Console.ReadKey();
        }
    }
}
