using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Repräsentiert den Speicher des LC3b.
public class Memory
{
    private const int MemorySize = 65536; // LC3 has a 16-bit address space.
    private int[] data = new int[MemorySize]; // The memory.

    // Lädt die Instruktionen in den Speicher.
    public void LoadInstructions(string[] instructions)
    {
        for (int i = 0; i < instructions.Length; i++)
        {
            data[i] = Convert.ToInt32(instructions[i], 2);
            Console.WriteLine($"Instruction loaded at address {i}: {Convert.ToString(data[i], 2).PadLeft(16, '0')}");
        }
    }

    // Liest eine Instruktion aus dem Speicher.
    public int Read(int address)
    {
        return data[address];
    }


    // Schreibt eine Instruktion in den Speicher.
    public void Write(int address, int value)
    {
        data[address] = value;
    }

    public void Display(string value)
    {
        Console.WriteLine("Output: " + value);
    }
}




