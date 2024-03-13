using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LC3bSimulator
{
    private ProgramCounter pc = new ProgramCounter();
    private Memory memory = new Memory();
    private InstructionRegister ir = new InstructionRegister();
    private Decoder decoder = new Decoder();
    private Register registers = new Register();
    private ALU alu = new ALU();
    private Output output = new Output();

    // Methode zum Laden von Instruktionen aus einer Datei
    public List<string> LoadInstructionsFromFile(string filepath)
    {
        // Erstellt eine Liste, um die geladenen Instruktionen zu speichern
        List<string> instructions = new List<string>();
        // Liest alle Zeilen der Datei
        string[] lines = File.ReadAllLines(filepath);

        // Durchläuft jede Zeile der Datei
        foreach (string line in lines)
        {
            // Überprüft, ob die Zeile weder leer noch ein Kommentar ist
            if (!string.IsNullOrWhiteSpace(line) && !line.Trim().StartsWith("//"))
            {
                // Fügt die bereinigte Instruktion zur Liste hinzu
                instructions.Add(line.Trim());
            }
        }

        return instructions;
    }

    //Ausführen des Simulators
    public void Run(string[] instructions)
    {
        memory.LoadInstructions(instructions);
        while (pc.Value < instructions.Length)
        {
            int instruction = memory.Read(pc.Value);
            ir.LoadInstruction(instruction);
            decoder.DecodeAndExecute(ir.Value, registers, alu, output, memory);
            pc.Increment();
        }
    }
}

