using Instruction_LC3b.CPU;
using Instruction_LC3b.Instructions;

namespace Instruction_LC3b;

internal class Program
{

    #region Felder

    private static Dictionary<int, IInstruction?> instructionSet = [];
    private static readonly InstructionDecoder InstructionDecoder = new();
    private static Memory memory = new();
    private static ProgramCounter programCounter = new();
    private static Registers registers = new();

    #endregion

    #region Methoden

    private static void Main(string[] args)
    {
        // Lade die Instruktionen in den Memory
        LoadInstructionFile();

        // Initialisiere den CPU InstructionSet
        InitializeInstructionSet();

        // Einfaches Ausführen der geladenen Instruktionen
        while (programCounter.Counter < memory.UsedStorage())
        {
            InstructionDecoder.ExecuteInstruction(ref memory, ref programCounter, ref registers, ref instructionSet);
        }

        // Zeige den Inhalt der GeneralPurposeRegisters an
        for(var i = 0; i < registers.GeneralPurposeRegisters.Length; i++)
        {
            Console.WriteLine($"R{i}: {registers.GeneralPurposeRegisters[i]}");
        }
    }

    private static void InitializeInstructionSet()
    {
        instructionSet.Add(0b0001, new AddInstruction());
        instructionSet.Add(0b0010, new LdbInstruction());
        //instructionSet.Add(0b0101, new AndInstruction());
    }

    private static void LoadInstructionFile()
    {
        // Pfad zur Datei mit LC-3b Instruktionen
        var basePath = AppDomain.CurrentDomain.BaseDirectory;
        var relativePath = Path.Combine(@"..\..\..\", "instruction_file.txt");
        var filePath = Path.Combine(basePath, relativePath);

        // Lade die Instruktionen aus der Datei in den Memory
        var lines = File.ReadAllLines(filePath);

        // Entferne alle Kommentarzeilen
        lines = lines.Where(l => !l.TrimStart().StartsWith("//")).ToArray();

        for (var index = 0; index < lines.Length; index++)
        {
            memory.WriteByte(index, Convert.ToUInt16(lines[index], 2));
        }
    }

    #endregion

}