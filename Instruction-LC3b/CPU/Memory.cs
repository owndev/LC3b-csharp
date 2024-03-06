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

    public int UsedStorage() { return Data.Count(t => t != 0); }

    #endregion


    //public byte ReadByte(int address)
    //{
    //    var wordIndex = address / 2; // Berechne den Wortindex
    //    var isHighByte = address % 2 == 0; // Prüfe, ob es das hohe Byte ist
    //    var word = Data[wordIndex];

    //    if(isHighByte)
    //    {
    //        return (byte)(word >> 8 & 0xFF); // Extrahiere das hohe Byte
    //    }

    //    return (byte)(word & 0xFF); // Extrahiere das niedrige Byte
    //}

    //public void WriteByte(int address, byte value)
    //{
    //    var wordIndex = address / 2; // Berechne den Wortindex
    //    var isHighByte = address % 2 == 0; // Prüfe, ob es das hohe Byte ist
    //    var word = Data[wordIndex];

    //    if(isHighByte)
    //    {
    //        // Setze das hohe Byte
    //        word = (ushort)((word & 0x00FF) | (value << 8));
    //    }
    //    else
    //    {
    //        // Setze das niedrige Byte
    //        word = (ushort)((word & 0xFF00) | value);
    //    }

    //    Data[wordIndex] = word; // Schreibe das Wort zurück in das Array
    //}
}