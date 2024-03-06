namespace Instruction_LC3b.CPU;

public class Registers
{

    #region Eigenschaften

    public ushort[] GeneralPurposeRegisters { get; private set; } = new ushort[8];
    public ushort[] InstructionRegister { get; private set; } = new ushort[1];

    #endregion

}