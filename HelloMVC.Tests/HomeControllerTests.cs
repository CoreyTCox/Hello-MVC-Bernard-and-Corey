using HelloMVC.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HelloMVC.Tests
{
    public class HomeControllerTests : HomeController
    {
        [Fact]
        public void Index_Should_Return_View_Results()
        {
            var controller = new HomeController();
            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
