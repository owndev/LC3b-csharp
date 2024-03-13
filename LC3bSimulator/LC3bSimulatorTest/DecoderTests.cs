using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC3bSimulatorTest
{
    [TestFixture]
    public class DecoderTests
    {
        private Decoder _decoder;
        private Register _registers; 
        private ALU _alu;
        private Output _output;
        private Memory _memory;

        [SetUp]
        public void Setup()
        {
            // Mock-Objekte für die Abhängigkeiten erstellen
            _registers = new Register();
            _alu = new ALU();
            _output = new Output();
            _memory = new Memory();

            // Eine Instanz des Decoders erstellen, die die Mock-Objekte verwendet
            _decoder = new Decoder();
        }

        [Test]
        public void DecodeAndExecute_AddInstruction_AddsCorrectly()
        {
            // Arrangieren
            int instruction = 0x1C40; // Beispiel für eine ADD-Instruktion
            _registers[0] = 6; // Setzen Sie die Registerwerte direkt
            _registers[1] = 10;

            // Handeln
            _decoder.DecodeAndExecute(instruction, _registers, _alu, _output, _memory);

            // Überprüfen
            Assert.AreEqual(16, _registers[6]);
        }
    }

}
