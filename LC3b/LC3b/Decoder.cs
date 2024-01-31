using LC3b.LC3b.Instructions;

namespace LC3b.LC3b;

public class Decoder
{

    #region Felder

    private readonly Dictionary<int, IInstruction?> instructionSet;
    private readonly Memory memory;
    private readonly Register register;

    #endregion

    public Decoder(Memory memory, Register register)
    {
        this.memory = memory;
        this.register = register;
        instructionSet = new Dictionary<int, IInstruction?>();
        InitializeInstructionSet();
    }

    #region Methoden

    private void InitializeInstructionSet()
    {
        instructionSet.Add(0b0001, new AddInstruction());
        instructionSet.Add(0b0010, new LdbInstruction());
        instructionSet.Add(0b0101, new AndInstruction());
    }

    public void ExecuteInstruction()
    {
        var instruction = memory.FetchInstruction(register.ProgramCounter);
        var opCode = instruction >> 12 & 0xF; // Extrahiere den OpCode

        if (instructionSet.TryGetValue(opCode, out IInstruction? instructionToExecute))
        {
            instructionToExecute?.Execute(instruction, register, memory); // TODO: OpCode nicht mehr übergeben
            register.ProgramCounter++; // Gehe zur nächsten Instruktion
        }
        else
        {
            Console.WriteLine($"Unbekannte Instruktion mit OpCode: {opCode}");
        }
    }

    #endregion

}