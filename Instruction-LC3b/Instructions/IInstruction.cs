using Instruction_LC3b.CPU;

namespace Instruction_LC3b.Instructions;

public interface IInstruction
{

    #region Methoden

    void Execute(ushort instruction, ref Registers registers, ref Memory memory);

    #endregion

}