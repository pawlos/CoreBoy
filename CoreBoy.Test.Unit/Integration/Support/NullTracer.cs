﻿using System.Diagnostics;
using System.Text;
using CoreBoy.cpu;

namespace CoreBoy.Test.Unit.Integration.Support
{
    public class NullTracer : ITracer
    {
        private int Counter { set; get; }

        public void Collect(Registers state)
        {
            Counter++;

            /*if (Counter == 93367)
            {
                Debugger.Break();
            }*/
        }

        public void Save()
        {
        }
    }
}