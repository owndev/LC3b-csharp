namespace LC3b.LC3b;

public class Register
{

    #region Eigenschaften

    public ushort ProgramCounter { get; set; }
    public ushort[] GeneralPurposeRegisters { get; private set; } = new ushort[8];

    #endregion

}