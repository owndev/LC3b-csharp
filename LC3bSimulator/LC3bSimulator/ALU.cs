using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Repräsentiert die Arithmetisch-Logische Einheit (ALU) des LC3b.
public class ALU
{
    // Führt die Add-Instruction zweier Werte aus und gibt das Ergebnis zurück.
    public int Add(int value1, int value2)
    {
        return value1 + value2;
    }

    // Führt die And-Instruction zweier Werte aus und gibt das Ergebnis zurück.
    public int And(int value1, int value2)
    {
        return value1 & value2;
    }

    // Führt die Ldb-Instruction auf einem Wert aus und gibt das Ergebnis zurück.
    public int Ldb(int value)
    {
        return (value << 24) >> 24;
    }
}




