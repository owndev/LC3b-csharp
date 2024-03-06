namespace LC3b.LC3b.Instructions;

public interface IInstruction
{

    #region Methoden

    void Execute(ushort instruction, Register register, Memory memory);

    #endregion

}