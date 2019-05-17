using System;
using System.Collections.Generic;
using System.Text;

namespace AnimInterf
{
    class Dog : Animal, IMammal
    {
        public int NumberOfNipples { get; }
        public override string Sound() => "Woof!";

        public Dog()
        {
            NumberOfNipples = 8;
        }

        public override string ToString()
        {
            return "Dog";
        }
    }
}
