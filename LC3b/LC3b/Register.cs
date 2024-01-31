namespace LC3b.LC3b;

public class Register
{

    #region Eigenschaften

    public ushort ProgramCounter { get; set; }
    public ushort[] GeneralPurposeRegisters { get; private set; }

    #endregion

    public Register() { GeneralPurposeRegisters = new ushort[8]; }
}