using SimpleAPI.Controllers;
using System;
using Xunit;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
        [Fact]
        public void GetReturnsCorrectNumber()
        {
            var returnValue = controller.Get(1);

            Assert.Equal("Yash Dua", returnValue.Value);
        }
    }
}
