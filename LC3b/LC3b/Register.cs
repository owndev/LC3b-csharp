using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC3bSimulator.LC3b
{
    public class Register
    {
        public ushort PC { get; set; }
        public ushort[] GeneralPurposeRegisters { get; private set; }

        public Register()
        {
            GeneralPurposeRegisters = new ushort[8];
        }
    }
}
