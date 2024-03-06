using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruction_LC3b.CPU;

public class Registers
{
    public ushort[] InstructionRegister { get; private set; } = new ushort[1];

    public ushort[] AluRegister { get; private set; } = new ushort[1];

    public ushort[] GeneralPurposeRegisters { get; private set; } = new ushort[8];
}