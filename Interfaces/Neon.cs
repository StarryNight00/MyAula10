using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Neon : IFuel
    {
        public float Efficiency { get { return 12.6f;} };
        public void Burn()
        {
            bool burn =  true;
        }
    }
}
