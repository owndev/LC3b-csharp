using Instruction_LC3b.CPU;

namespace Instruction_LC3b.Instructions;

public class LdbInstruction : IInstruction
{
    public void Execute(ushort instruction, ref Registers registers, ref Memory memory)
    {
        var dr = instruction >> 9 & 0x7; // Destination Register
        var baseR = instruction >> 6 & 0x7; // Base Register
        var offset6 = instruction & 0x3F; // Offset 6

        // Sign Extension für offset6
        if ((offset6 & 0x20) != 0)
        {
            offset6 |= 0xFFC0;
        }

        var effectiveAddress = registers.GeneralPurposeRegisters[baseR] + offset6;
        var value = memory.ReadByte(effectiveAddress); // Lies Byte aus dem Speicher

        // Sign Extension für das geladene Byte
        var extendedValue = value > 127
            ? (ushort)(value | 0xFF00)
            : value;

        registers.GeneralPurposeRegisters[dr] = extendedValue;
    }
}