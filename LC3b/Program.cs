using LC3b.LC3b;

internal class Program
{

    #region Methoden

    private static void Main(string[] args)
    {
        // Pfad zur Datei mit LC-3b Instruktionen
        var basePath = AppDomain.CurrentDomain.BaseDirectory;
        var relativePath = Path.Combine(@"..\..\..\", "instruction_file.txt");
        var filePath = Path.Combine(basePath, relativePath);


        // Initialisierung der Simulator-Komponenten
        var memory = new Memory(filePath);
        var register = new Register();
        var cpu = new Decoder(memory, register);

        // Einfaches Ausführen der geladenen Instruktionen
        while (register.ProgramCounter < memory.Data.Length) // TODO: Anpassen!
        {
            cpu.ExecuteInstruction();
        }

        // Ausgabe der Registerwerte zur Überprüfung
        Console.WriteLine("Ausführung abgeschlossen. Registerzustände:");

        for (var i = 0; i < register.GeneralPurposeRegisters.Length; i++)
        {
            Console.WriteLine($"R{i}: {register.GeneralPurposeRegisters[i]}");
        }
    }

    #endregion

}