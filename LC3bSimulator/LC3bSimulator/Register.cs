using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Repräsentiert die Register des LC3b.
public class Register
{
    // Die Register des LC3b.
    private int[] registers = new int[8];

    // Gibt den Wert des Registers mit dem angegebenen Index zurück oder legt diesen fest.
    public int this[int i]
    {
        get { return registers[i]; }
        set { registers[i] = value; }
    }
}

