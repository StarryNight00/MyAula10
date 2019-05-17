﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnimInterf
{
    class Dog : Animal, IMammal
    {
        public int NumberOfNipples => 8;
        public override string Sound() => "Woof!";

        public override string ToString()
        {
            return "Dog";
        }
    }
}
