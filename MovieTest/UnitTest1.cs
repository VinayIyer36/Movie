using Microsoft.Extensions.Logging;
using Moq;
using Movie.Controllers;
using Movie.Repository;
using NUnit.Framework;

namespace MovieTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetMovie_ReturnsOkResult_WhenMovieExists()
        {
            var mockLogger = new Mock<ILogger<MovieController>>();

            var controller = new MovieController(mockLogger.Object);

            // Act
            var result = controller.GetMovie(1);

            // Assert
            Assert.IsInstanceOf(typeof(Microsoft.AspNetCore.Mvc.OkObjectResult), result);
        }
    }
}