using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using KATA1;

namespace KATA4.Calculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void when_1s_and_4_and_half_d_was_used()
        {
            // Arrange

            var calculator = new ChangeCalculator();
            
            // Act

            var result = calculator.Calculate(1, 4.5);

            // Assert

            Assert.AreEqual(4, result.Count);

            Assert.IsTrue(result.ContainsKey("Shilling"));
            Assert.AreEqual(1, result["Shilling"]);

            Assert.IsTrue(result.ContainsKey("Threepenny bit"));
            Assert.AreEqual(1, result["Threepenny bit"]);

            Assert.IsTrue(result.ContainsKey("Penny"));
            Assert.AreEqual(1, result["Penny"]);

            Assert.IsTrue(result.ContainsKey("Halfpenny"));
            Assert.AreEqual(1, result["Halfpenny"]);
        }

        [Test]
        public void when_3s_was_used()
        {
            // Arrange

            var calculator = new ChangeCalculator();

            // Act

            var result = calculator.Calculate(3, 0);

            // Assert

            Assert.AreEqual(2, result.Count);

            Assert.IsTrue(result.ContainsKey("Half Crown"), "The result should contain halfcrown");
            Assert.AreEqual(1, result["Half Crown"]);

            Assert.IsTrue(result.ContainsKey("Sixpenny bit"));
            Assert.AreEqual(1, result["Sixpenny bit"]);
        }
    }
}
