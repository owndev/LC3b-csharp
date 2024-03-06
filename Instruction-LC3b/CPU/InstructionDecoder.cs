using Instruction_LC3b.Instructions;

namespace Instruction_LC3b.CPU;

public class InstructionDecoder
{

    #region Methoden

    public void ExecuteInstruction(ref Memory memory, ref ProgramCounter programCounter, ref Registers registers, ref Dictionary<int, IInstruction?> instructionSet)
    {
        // Laden der Instruktion in den Befehlsregister
        var instruction = memory.ReadByte(programCounter.Counter);
        registers.InstructionRegister[0] = instruction;

        var opCode = instruction >> 12 & 0xF; // Extrahiere den OpCode

        if (instructionSet.TryGetValue(opCode, out IInstruction? instructionToExecute))
        {
            instructionToExecute?.Execute(registers.InstructionRegister[0], ref registers, ref memory);
            programCounter.Counter++; // Gehe zur nächsten Instruktion
        }
        else
        {
            Console.WriteLine($"Unbekannte Instruktion mit OpCode: {opCode}");
        }
    }

    #endregion

}