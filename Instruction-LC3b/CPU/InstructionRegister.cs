using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruction_LC3b.CPU;

public class InstructionRegister
{
    public ushort[] Register { get; private set; } = new ushort[16];
}