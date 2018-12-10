using FluentAssertions;
using NSubstitute;
using Xunit;

namespace BankKataTest
{
    public class AcceptanceTest
    {
        [Theory, AutoNSubstituteData]
        public void DummyTest(IShouldWork sut)
        {
            // Arrange
            sut.DoIt().Returns(true);

            // Act
            var result = sut.DoIt();

            // Assert
            result.Should().BeTrue();
        }
    }

    public interface IShouldWork
    {
        bool DoIt();
    }
}