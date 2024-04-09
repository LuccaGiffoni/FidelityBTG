namespace FidelityBTG.Tests;

public class ClientTests
{
    [Fact]
    public void FullName_ReturnsConcatenatedNameAndLastName()
    {
        // Arrange
        var client = new Client { Name = "John", LastName = "Doe" };

        // Act
        var fullName = client.FullName;

        // Assert
        Assert.Equal("John Doe", fullName);
    }

    [Fact]
    public void GetClientAge_ReturnsCorrectAge()
    {
        // Arrange
        var birthday = new DateTime(1990, 5, 15);
        var client = new Client { Birthday = birthday };

        // Act
        var age = client.GetClientAge();

        // Assert
        Assert.Equal(31, age); // Assuming today's date is 2021-05-15
    }
}
