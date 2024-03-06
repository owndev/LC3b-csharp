namespace LC3b.LC3b;

public class Memory(string filePath)
{

    #region Eigenschaften

    public Loader Loader { get; } = new(filePath);

    private ushort[] Data { get; } = new ushort[65535]; // Initialisieren mit 2^16 x 16 Bit

    #endregion

    #region Methoden

    public ushort FetchInstruction(int address) { return Loader.Instructions[address]; }

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