﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Repräsentiert den Befehlszähler des LC3b.
public class ProgramCounter
{
    // Der Wert des Befehlszählers.
    public int Value { get; set; }

    public ProgramCounter()
    {
        Value = 0; // Der Befehlszähler wird initial auf 0 gesetzt.
    }

    // Inkrementiert den Befehlszähler.
    public void Increment()
    {
        Value++;
    }

    // Setzt den Befehlszähler auf den angegebenen Wert.
    public void Set(int address)
    {
        Value = address;
    }
}

