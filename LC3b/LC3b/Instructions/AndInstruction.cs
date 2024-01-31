using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC3bSimulator.LC3b.Instructions
{
    public class AndInstruction : IInstruction
    {
        public void Execute(ushort instruction, Register register)
        {
            int dr = (instruction >> 9) & 0x7; // Destination Register
            int sr1 = (instruction >> 6) & 0x7; // Source Register 1
            bool immediate = (instruction & 0x20) != 0; // Immediate Flag

            //Still Implementing
        }
    }
}
