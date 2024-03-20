using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LC3bSimulator
{
    // Instanzen der Komponenten des Simulators
    private ProgramCounter pc = new ProgramCounter();
    private Memory memory = new Memory();
    private InstructionRegister ir = new InstructionRegister();
    private Decoder decoder = new Decoder();
    private Register registers = new Register();
    private ALU alu = new ALU();

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
        // Lädt die Instruktionen in den Speicher
        memory.LoadInstructions(instructions);
        // Führt die Instruktionen aus
        while (pc.Value < instructions.Length)
        {
            // Liest die Instruktion aus dem Speicher
            int instruction = memory.Read(pc.Value);
            // Lädt die Instruktion in das Instruktionsregister
            ir.LoadInstruction(instruction);
            // Dekodiert und führt die Instruktion aus
            decoder.DecodeAndExecute(ir.Value, registers, alu, memory);
            // Inkrementiert den Program Counter
            pc.Increment();
        }
    }
}

