using System;
using System.Collections.Generic;
using System.Text;

namespace AnimInterf
{
    class Bee : Animal, ICanFly
    {
        public int NumberOfWings { get; }
        public override string Sound() => "Bzz, Bzz!";

        public Bee()
        {
            NumberOfWings = 4;
        }

        public override string ToString()
        {
            return "Bee";
        }
    }
}
