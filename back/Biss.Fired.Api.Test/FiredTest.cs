using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System.Threading.Tasks;
using Biss.Fired.Api.Controllers;
using Microsoft.Extensions.Logging;
using Moq;

namespace Biss.Fired.Api.Test
{
    public class FiredTests
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
        public async Task GetFired_ReturnsOkResult()
        {
            var logger = Mock.Of<ILogger<FiredController>>();           
            var controller = new FiredController(logger);
            // Act
            var result = await controller.GetFired();
            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result.Result);

        }
        [Test]
        public async Task GetFiredByName_ReturnsOkResult()
        {
            var logger = Mock.Of<ILogger<FiredController>>();
            var controller = new FiredController(logger);
            // Act
            var name = "João";
            var result = await controller.GetFiredByName(name);
            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result.Result);

        }
        [Test]
        public async Task PostFired_ReturnsOkResult()
        {
            var logger = Mock.Of<ILogger<FiredController>>();
            var controller = new FiredController(logger);
            // Act
            var name = "João";
            var result = await controller.PostFired(name);
            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result.Result);

        }
        [Test]
        public async Task PutFired_ReturnsOkResult()
        {
            var logger = Mock.Of<ILogger<FiredController>>();
            var controller = new FiredController(logger);
            // Act
            var name = "João";
            var result = await controller.PutFired(name);
            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result.Result);

        }        
    }
}