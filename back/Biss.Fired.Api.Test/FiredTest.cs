using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System.Threading.Tasks;
using Biss.Fired.Api.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
using System;

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
            var name = "Cuca";
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
            var fired = new Models.Fired() { Name = "João" };
            var result = await controller.PostFired(fired);
            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result.Result);

        }
        [Test]
        public async Task PutFired_ReturnsOkResult()
        {
            var logger = Mock.Of<ILogger<FiredController>>();
            var controller = new FiredController(logger);
            // Act
            var fired = new Models.Fired() { Name = "João" };
            var result = await controller.PutFired(fired);
            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result.Result);

        }
        [Test]
        public async Task PostFired_InvalidModel_ReturnsBadRequest()
        {
            // Arrange
            var logger = Mock.Of<ILogger<FiredController>>();
            var controller = new FiredController(logger);
            var fired = new Models.Fired() { Name = "" }; // modelo inválido, Name é obrigatório
            controller.ModelState.AddModelError("Name", "Name é obrigatório.");
            // Act
            var result = await controller.PostFired(fired);
            // Assert
            Assert.IsInstanceOf<BadRequestObjectResult>(result.Result);
        }
    }
}