using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LC3bSimulatorTest
{
    [TestFixture]
    public class ALUTests
    {
        [Test]
        // Testet die Add-Methode der ALU
        public void Add_ShouldCorrectlyAddTwoNumbers()
        {
            // Vorbereiten, Initialisiere die ALU und die Testdaten
            var alu = new ALU();
            int operand1 = 5;
            int operand2 = 7;

            // Ausführen, Führe die zu testende Methode aus
            int result = alu.Add(operand1, operand2);

            // Überprüfe das Ergebnis
            Assert.AreEqual(12, result, "Die Add-Methode der ALU sollte die Zahlen korrekt addieren.");
        }
    }
}
