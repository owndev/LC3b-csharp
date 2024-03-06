using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Repräsentiert das Instruktionsregister des LC3b.
public class InstructionRegister
{
    public int Value { get; private set; }

    // Lädt eine Instruktion in das Register.
    public void LoadInstruction(int instruction)
    {
        Value = instruction;
    }
}

