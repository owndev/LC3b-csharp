using Instruction_LC3b.CPU;

namespace Instruction_LC3b
{
    internal class Program
    {
        private static Memory Memory { get; set; } = new();

        static void Main(string[] args)
        {
            // Lade die Instruktionen in den Memory
            LoadInstruction();


        }

        private static void LoadInstruction()
        {
            // Pfad zur Datei mit LC-3b Instruktionen
            var basePath = AppDomain.CurrentDomain.BaseDirectory;
            var relativePath = Path.Combine(@"..\..\..\", "instruction_file.txt");
            var filePath = Path.Combine(basePath, relativePath);

            // Lade die Instruktionen aus der Datei in den Memory
            var lines = File.ReadAllLines(filePath);

            for(var index = 0; index < lines.Length; index++)
            {
                var line = lines[index];

                // Überprüfe, ob die Zeile mit "//" beginnt
                if(!line.TrimStart().StartsWith("//"))
                {
                    Memory.WriteByte(index, Convert.ToUInt16(line, 2));
                }
            }
        }
    }
}
