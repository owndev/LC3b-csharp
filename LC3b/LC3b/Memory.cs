using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC3bSimulator.LC3b
{
    public class Memory
    {
        public ushort[] Instructions { get; private set; }

        public Memory(string filePath)
        {
            LoadInstructionsFromFile(filePath);
        }

        private void LoadInstructionsFromFile(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            Instructions = new ushort[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                Instructions[i] = Convert.ToUInt16(lines[i], 2);
            }
        }

        public ushort FetchInstruction(int address)
        {
            return Instructions[address];
        }
    }
}
