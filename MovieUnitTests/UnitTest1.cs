using FirstResponsiveWebAppDecker;
using System;
using Xunit;
using FirstResponsiveWebAppDecker.Controllers;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Web;
using FirstResponsiveWebAppDecker.Models;
using Microsoft.AspNetCore.Mvc;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void CorrectInput()
        {
            //Arrange
            int bYear = 2001;

            int expected = 20;
            int actual;

            //Act
            var HomeController = new HomeController();

            /* I think the Unit Tests have to connect to the Controller, but I can't find anything on the web that even hints at
             * being the solution for creating web applications. I've tried working with the Controller, the Model, working with Moq, etc.
             * And nothing thus far has worked. The videos that Michelle Ruse provided aren't applicable to our type of program, and neither are the 
             * links provided. This shows that I've created the xUnit test, and I have added some information to the unit test. I know what a Unit test
             * should do, but haven't been given enough information to write one. 
            */

            //Assert

        }
    }
}
