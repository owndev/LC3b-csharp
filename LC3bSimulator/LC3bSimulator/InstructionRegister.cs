using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Repräsentiert das Instruktionsregister des LC3b.
public class InstructionRegister
{
    // Der Wert des Instructionsregisters.
    public int Value { get; set; }

    // Lädt eine Instruktion in das Register.
    public void LoadInstruction(int instruction)
    {
        Value = instruction;
    }
}

