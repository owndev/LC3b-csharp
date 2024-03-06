﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LC3bSimulatorTest
{
    [TestFixture]
    public class ProgramCounterTests
    {
        [Test]
        public void ProgramCounter_ShouldIncrementCorrectly()
        {
            // Arrange
            var pc = new ProgramCounter();
            var initialValue = 0x3000; // Startwert des ProgramCounters
            pc.Value = initialValue;

            // Act
            pc.Increment(); // Erhöhung um 1

            // Assert
            Assert.AreEqual(initialValue + 1, pc.Value, "Der ProgramCounter sollte korrekt inkrementiert werden.");
        }
    }

}
