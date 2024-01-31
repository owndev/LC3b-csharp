namespace LC3b.LC3b;

public class Memory
{

    #region Eigenschaften

    public ushort[] Data { get; private set; } = new ushort[65535]; // Initialisieren mit 2^16 x 16 Bit

    #endregion


    public Memory(string filePath) { LoadInstructionsFromFile(filePath); }

    #region Methoden

    public ushort FetchInstruction(int address) { return Data[address]; }

    public byte ReadByte(int address)
    {
        var wordIndex = address / 2; // Berechne den Wortindex
        var isHighByte = address % 2 == 0; // Prüfe, ob es das hohe Byte ist
        var word = Data[wordIndex];

        if (isHighByte)
        {
            return (byte)(word >> 8 & 0xFF); // Extrahiere das hohe Byte
        }

        return (byte)(word & 0xFF); // Extrahiere das niedrige Byte
    }

    #endregion

}