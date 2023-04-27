using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System.Threading.Tasks;
using Biss.Fired.Api.Controllers;
using Microsoft.Extensions.Logging;
using Moq;

namespace Biss.Fired.Api.Test
{
    public class MediaTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestExample()
        {
            Assert.Pass();
        }
        
        [Test]
        public async Task GetMedia_ReturnsOkResult()
        {
            var logger = Mock.Of<ILogger<MediaController>>();
            var controller = new MediaController(logger);
            // Act
            var firedId = 1;
            var result = await controller.GetMedia(firedId);
            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result.Result);

        }
        [Test]
        public async Task PostMedia_ReturnsOkResult()
        {
            var logger = Mock.Of<ILogger<MediaController>>();
            var controller = new MediaController(logger);
            string media = "";
            // Act
            var result = await controller.PostMedia(media);
            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result.Result);

        }
    }
}