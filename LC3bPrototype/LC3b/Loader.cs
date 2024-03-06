namespace LC3b.LC3b;

public class Loader
{

    #region Eigenschaften

    public ushort[] Instructions { get; private set; } = [];

    #endregion

    public Loader(string filePath) { LoadInstructionsFromFile(filePath); }

    #region Methoden

    private void LoadInstructionsFromFile(string filePath)
    {
        var lines = File.ReadAllLines(filePath);
        Instructions = new ushort[lines.Length];

        var instructionIndex = 0; // Index für das Instructions-Array

        foreach (var line in lines)
        {
            // Überprüfe, ob die Zeile mit "//" beginnt
            if (!line.TrimStart().StartsWith("//"))
            {
                Instructions[instructionIndex++] = Convert.ToUInt16(line, 2);
            }
        }

        // Stelle sicher, dass das Array die richtige Größe hat
        Instructions = Instructions.Take(instructionIndex).ToArray();
    }

    #endregion

}