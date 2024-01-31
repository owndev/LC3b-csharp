using LC3bSimulator.LC3b;

class Program
{
    static void Main(string[] args)
    {
        // Pfad zur Datei mit LC-3b Instruktionen
        string basePath = AppDomain.CurrentDomain.BaseDirectory;
        string relativePath = Path.Combine(@"..\..\..\", "instruction_file.txt");
        string filePath = Path.Combine(basePath, relativePath);
     

        // Initialisierung der Simulator-Komponenten
        Memory memory = new Memory(filePath);
        Register register = new Register();
        CPU cpu = new CPU(memory, register);

        // Einfaches Ausführen der geladenen Instruktionen
        while (register.PC < memory.Instructions.Length)
        {
            cpu.ExecuteInstruction();
        }

        // Ausgabe der Registerwerte zur Überprüfung
        Console.WriteLine("Ausführung abgeschlossen. Registerzustände:");
        for (int i = 0; i < register.GeneralPurposeRegisters.Length; i++)
        {
            Console.WriteLine($"R{i}: {register.GeneralPurposeRegisters[i]}");
        }
    }
}