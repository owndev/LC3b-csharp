using Instruction_LC3b.CPU;
using Instruction_LC3b.Instructions;

namespace TestLC3b
{
    [TestClass]
    public class InstructionTests
    {
        [TestMethod]
        public void TestAddInstruction1()
        {
            var registers = new Registers();
            var memory = new Memory();
            var instruction = new AddInstruction();

            // R1 und R2 setzen
            registers.GeneralPurposeRegisters[1] = 7;
            registers.GeneralPurposeRegisters[2] = 4;

            // ADD R3 <- R1 + R2
            registers.InstructionRegister[0] = 0b0001011001000010;

            // Führe die AddItionsinstruktion aus
            instruction.Execute(registers.InstructionRegister[0], ref registers, ref memory);

            var expected = registers.GeneralPurposeRegisters[1] + registers.GeneralPurposeRegisters[2];

            Assert.AreEqual(expected, registers.GeneralPurposeRegisters[3]);
        }

        [TestMethod]
        public void TestAddInstruction2()
        {
            var registers = new Registers();
            var memory = new Memory();
            var instruction = new AddInstruction();

            // ADD R1 <- R1 + 1
            registers.InstructionRegister[0] = 0b0001001001100001;

            // Führe die AddItionsinstruktion aus
            instruction.Execute(registers.InstructionRegister[0], ref registers, ref memory);

            Assert.AreEqual(1, registers.GeneralPurposeRegisters[1]);
        }

        [TestMethod]
        public void TestLdbInstruction1()
        {
            var registers = new Registers();
            var memory = new Memory();
            var instruction = new LdbInstruction();

            memory.WriteByte(1, 1);

            // LDB R1 (GPRegister) <- R1 (Memory) + 1
            registers.InstructionRegister[0] = 0b0010001001000001;

            // Führe die LdbInstruktion aus
            instruction.Execute(registers.InstructionRegister[0], ref registers, ref memory);

            Assert.AreEqual(1, registers.GeneralPurposeRegisters[1]);
        }

        [TestMethod]
        public void TestLdbInstruction2()
        {
            var registers = new Registers();
            var memory = new Memory();
            var instruction = new LdbInstruction();

            memory.WriteByte(2, 2);

            // LDB R2 (GPRegister) <- R2 (Memory) + 2
            registers.InstructionRegister[0] = 0b0010010010000010;

            // Führe die LdbInstruktion aus
            instruction.Execute(registers.InstructionRegister[0], ref registers, ref memory);

            Assert.AreEqual(2, registers.GeneralPurposeRegisters[2]);
        }
    }
}