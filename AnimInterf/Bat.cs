using System;
using System.Collections.Generic;
using System.Text;

namespace AnimInterf
{
    class Bat : Animal, IMammal, ICanFly
    {
        public int NumberOfNipples => 2;
        public int NumberOfWings => 2;
        public override string Sound() => "Cree!";

        public override string ToString()
        {
            return "Bat";
        }
    }
}
}
