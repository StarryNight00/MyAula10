using System;
using System.Collections.Generic;
using System.Text;

namespace AnimInterf
{
    class Cat : Animal, IMammal
    {
        public int NumberOfNipples => 6;
        public override string Sound() => "Miau!";

        public override string ToString()
        {
            return "Cat";
        }
    }
}
}
