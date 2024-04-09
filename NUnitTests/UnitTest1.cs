using System;
using NUnit.Framework;
using FidelityBTG.MVVM.Models;

namespace FidelityBTG.NUnitTests
{
    public class ClientTests
    {
        [Test]
        public void FullName_ReturnsConcatenatedNameAndLastName()
        {
            // Arrange
            var client = new Client { Name = "John", LastName = "Doe" };

            // Act
            var fullName = client.FullName;

            // Assert
            Assert.AreEqual("John Doe", fullName);
        }

        [Test]
        public void GetClientAge_ReturnsCorrectAge()
        {
            // Arrange
            var birthday = new DateTime(1990, 5, 15);
            var client = new Client { Birthday = birthday };

            // Act
            var age = client.GetClientAge();

            // Assert
            Assert.AreEqual(31, age); // Assuming today's date is 2021-05-15
        }
    }
}
