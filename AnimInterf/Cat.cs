using System;
using System.Collections.Generic;
using System.Text;

namespace AnimInterf
{
    class Cat : Animal, IMammal
    {
        public int NumberOfNipples { get; }
        public override string Sound() => "Miau!";

        public Cat()
        {
            NumberOfNipples = 8;
        }

        public override string ToString()
        {
            return "Cat";
        }
    }
}

