using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC3bSimulatorTest
{
    [TestFixture]
    public class MemoryTests
    {
        [Test]
        public void Memory_ShouldStoreAndRetrieveValue()
        {
            // Arrange
            var memory = new Memory();
            var testAddress = 0x3000; // Test-Adresse
            var testValue = 0x25; // Test-Wert

            // Act
            memory.Write(testAddress, testValue);
            var result = memory.Read(testAddress);

            // Assert
            Assert.AreEqual(testValue, result, "Der Speicher sollte den gespeicherten Wert korrekt abrufen.");
        }
    }

}
