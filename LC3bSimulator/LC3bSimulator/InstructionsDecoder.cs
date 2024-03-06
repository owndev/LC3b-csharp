using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class InstructionsDecoder
{

    //Dekodiert und führt die Instruktion aus.
    public void DecodeAndExecute(int instruction, Register registers, ALU alu, Output output)
    {
        int opcode = (instruction >> 12) & 0xF;
        switch (opcode)
        {
            case 0x1: // ADD instruction
                int dr = (instruction >> 9) & 0x7; // Destination Register (bits[11:9]) 
                int sr1 = (instruction >> 6) & 0x7; // Source Register 1 (bits[8:6])
                bool mode = ((instruction >> 5) & 0x1) != 0;  // Immediate mode (bit[5])
                if (!mode)
                {
                    int sr2 = instruction & 0x7; // Source Register 2 (bits[2:0])
                    registers[dr] = alu.Add(registers[sr1], registers[sr2]);
                }
                else
                {
                    int imm5 = instruction & 0x1F; // Immediate value (bits[4:0])
                    if ((imm5 & 0x10) > 0) // Check if imm5 is negative
                    {
                        imm5 |= 0xFFE0; // Sign extend imm5
                    }
                    registers[dr] = alu.Add(registers[sr1], imm5);
                }
                output.Display(registers[dr]);
                break;
                // Weiterer Code für die anderen Instruktionen
        }
    }
}


