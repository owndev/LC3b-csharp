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
        private Memory _memory;

        [SetUp]
        public void Setup()
        {
            // Instanz von Decoder, Register, ALU und Memory erstellen
            _registers = new Register();
            _alu = new ALU();
            _memory = new Memory();
            _decoder = new Decoder();
        }

        [Test]
        public void DecodeAndExecute_AddInstruction_AddsCorrectly()
        {
            // Vorbereiten
            int instruction = 0x1C40; // Beispiel für eine ADD-Instruktion
            _registers[0] = 6; // Setzen Sie die Registerwerte direkt
            _registers[1] = 10;

            // Ausführen
            _decoder.DecodeAndExecute(instruction, _registers, _alu, _memory);

            // Überprüfen
            Assert.AreEqual(16, _registers[6]);
        }
    }

}
