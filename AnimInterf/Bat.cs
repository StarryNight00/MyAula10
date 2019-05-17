using System;
using System.Collections.Generic;
using System.Text;

namespace AnimInterf
{
    class Bat : Animal, IMammal, ICanFly
    {
        public int NumberOfNipples { get; }
        public int NumberOfWings { get; }
        public override string Sound() => "I'm Batman.";

        public Bat()
        {
            NumberOfWings = 2;
            NumberOfNipples = 2;
        }

        public override string ToString()
        {
            return "Bat";
        }
    }
}
