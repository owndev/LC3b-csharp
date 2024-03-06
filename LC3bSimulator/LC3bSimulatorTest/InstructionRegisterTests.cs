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
            // Arrange
            var ir = new InstructionRegister();
            int testValue = 0x1234; // Test-Instruktion als Hexadezimalwert

            // Act
            ir.Value = testValue;

            // Assert
            Assert.AreEqual(testValue, ir.Value, "Das InstructionRegister sollte den gesetzten Wert halten.");
        }
    }

}
