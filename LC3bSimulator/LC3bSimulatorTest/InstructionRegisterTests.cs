using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC3bSimulatorTest
{
    [TestFixture]
    public class InstructionRegisterTests
    {
        [Test]
        public void InstructionRegister_ShouldHoldValue_WhenSet()
        {
            //  Vorbereiten
            var ir = new InstructionRegister();
            int testValue = 0x1234; // Test-Instruktion als Hexadezimalwert

            // Ausführen
            ir.Value = testValue;

            // Überprüfen
            Assert.AreEqual(testValue, ir.Value, "Das InstructionRegister sollte den gesetzten Wert halten.");
        }
    }

}
