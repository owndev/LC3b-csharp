namespace Instruction_LC3b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pfad zur Datei mit LC-3b Instruktionen
            var basePath = AppDomain.CurrentDomain.BaseDirectory;
            var relativePath = Path.Combine(@"..\..\..\", "instruction_file.txt");
            var filePath = Path.Combine(basePath, relativePath);


        }
    }
}
