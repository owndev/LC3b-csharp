using Instruction_LC3b.CPU;

namespace Instruction_LC3b.Instructions;

public class AndInstruction : IInstruction
{
    public void Execute(ushort instruction, ref Registers registers, ref Memory memory)
    {
        var dr = instruction >> 9 & 0x7; // Destination Register
        var sr1 = instruction >> 6 & 0x7; // Source Register 1
        var immediate = (instruction & 0x20) != 0; // Immediate Flag

        //Still Implementing
    }
}