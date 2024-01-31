using LC3bSimulator.LC3b.Instructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC3bSimulator.LC3b
{
    public class CPU
    {
        private Memory memory;
        private Register register;
        private Dictionary<int, IInstruction> instructionSet;

        public CPU(Memory memory, Register register)
        {
            this.memory = memory;
            this.register = register;
            instructionSet = new Dictionary<int, IInstruction>();
            InitializeInstructionSet();
        }

        private void InitializeInstructionSet()
        {
            instructionSet.Add(0x1, new AddInstruction());
            instructionSet.Add(0x5, new AndInstruction());
        }

        public void ExecuteInstruction()
        {
            ushort instruction = memory.FetchInstruction(register.PC);
            int opCode = (instruction >> 12) & 0xF; // Extrahiere den OpCode
            if (instructionSet.TryGetValue(opCode, out IInstruction instructionToExecute))
            {
                instructionToExecute.Execute(instruction, register);
                register.PC++; // Gehe zur nächsten Instruktion
            }
            else
            {
                Console.WriteLine($"Unbekannte Instruktion mit OpCode: {opCode}");
            }
        }
    }
}
