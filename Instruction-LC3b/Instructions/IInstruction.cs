using Instruction_LC3b.CPU;

namespace LC3b.LC3b.Instructions;

public interface IInstruction
{

    #region Methoden

    void Execute(ushort instruction, Registers registers, Memory memory);

    #endregion

}