namespace Instruction_LC3b.CPU;

public class Memory
{

    #region Eigenschaften

    private ushort[] Data { get; } = new ushort[65535]; // Initialisieren mit 2^16 x 16 Bit

    #endregion


    #region Methoden

    public ushort ReadByte(int address)
    {
        if (address < 0 || address >= Data.Length)
            return 0;
        return Data[address];
    }

    public void WriteByte(int address, ushort value)
    {
        if (address < 0 || address >= Data.Length)
            return;
        Data[address] = value;
    }


    #endregion

}