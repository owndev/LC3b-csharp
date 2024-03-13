using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Decoder
{

    //Dekodiert und führt die Instruktion aus.
    public void DecodeAndExecute(int instruction, Register registers, ALU alu, Memory memory)
    {
        int opcode = (instruction >> 12) & 0xF;
        switch (opcode)
        {
            case 0x1: // ADD instruction
                {
                    int dr = (instruction >> 9) & 0x7; // Zielregister
                    int sr1 = (instruction >> 6) & 0x7; // Quellregister 1
                    bool mode = ((instruction >> 5) & 0x1) != 0; // Adressierungsmodus
                    if (!mode)
                    {
                        int sr2 = instruction & 0x7; // Quellregister 2
                        registers[dr] = alu.Add(registers[sr1], registers[sr2]); // Führt die Addition aus
                    }
                    else
                    {
                        int imm5 = instruction & 0x1F; // Direktwert
                        imm5 = (imm5 << 27) >> 27; // Korrekte Sign-Erweiterung für 5-Bit-Werte
                        registers[dr] = alu.Add(registers[sr1], imm5); // Führt die Addition aus
                    }
                    memory.Display("ADD to Register: "+dr+", Value: "+ registers[dr]);// Gibt das Ergebnis aus
                    break;
                }
            case 0x2: // LDB instruction
                {
                    int dr = (instruction >> 9) & 0x7;// Zielregister
                    int baseR = (instruction >> 6) & 0x7;// Basisregister
                    int boffset6 = ((sbyte)(instruction << 26)) >> 26; // Korrekte Sign-Erweiterung für 6-Bit-Werte
                    int address = registers[baseR] + boffset6; // Berechnet die Adresse
                    int value = memory.Read(address) & 0xFF; // Liest den Speicher und maskiert das Ergebnis
                    registers[dr] =  alu.Ldb(value); // Korrekte Sign-Erweiterung des gelesenen Bytes
                    SetCC(registers[dr]);// Setzt die Flags
                    memory.Display("LDB to Register: " + dr + ", Value: " + registers[dr]);// Gibt das Ergebnis aus
                    break;
                }
            case 0x5: // AND instruction
                {
                    int dr = (instruction >> 9) & 0x7;// Zielregister
                    int sr1 = (instruction >> 6) & 0x7;// Quellregister 1
                    bool mode = ((instruction >> 5) & 0x1) != 0; // Adressierungsmodus
                    if (!mode)
                    {
                        int sr2 = instruction & 0x7;// Quellregister 2
                        registers[dr] = alu.And(registers[sr1], registers[sr2]);// Führt die logische UND-Operation aus
                    }
                    else
                    {
                        int imm5 = instruction & 0x1F;// Direktwert
                        imm5 = (imm5 << 27) >> 27; // Korrekte Sign-Erweiterung für 5-Bit-Werte
                        registers[dr] = registers[sr1] & imm5;// Führt die logische UND-Operation aus
                    }
                    SetCC(registers[dr]);
                    memory.Display("AND to Register: " + dr + ", Value: " + registers[dr]);
                    break;
                }
                // Weiterer Code für die anderen Instruktionen...
        }
    }

    private void SetCC(int value)
    {
        // Angenommen, N, Z, und P sind global zugängliche Flags. Anpassen, falls notwendig.
        bool N = value < 0;
        bool Z = value == 0;
        bool P = value > 0;
    }
}


