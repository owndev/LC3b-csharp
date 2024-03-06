namespace LC3b.LC3b.Instructions;

public class AddInstruction : IInstruction
{
    public void Execute(ushort instruction, Register register, Memory memory)
    {
        var dr = instruction >> 9 & 0x7; // Destination Register
        var sr1 = instruction >> 6 & 0x7; // Source Register 1
        var immediate = (instruction & 0x20) != 0; // Immediate Flag

        if (immediate)
        {
            var imm5 = instruction & 0x1F; // Immediate Value

            if ((imm5 & 0x10) != 0) // Sign Extension
            {
                imm5 |= 0xFFE0;
            }

            register.GeneralPurposeRegisters[dr] = (ushort)(register.GeneralPurposeRegisters[sr1] + imm5);
        }
        else
        {
            var sr2 = instruction & 0x7; // Source Register 2
            register.GeneralPurposeRegisters[dr] = (ushort)(register.GeneralPurposeRegisters[sr1] + register.GeneralPurposeRegisters[sr2]);
        }
    }
}