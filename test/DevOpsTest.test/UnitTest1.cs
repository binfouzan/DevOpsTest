using System;
using Xunit;
using DevOpsTest.api.Controllers;

namespace DevOpsTest.test
{
    public class UnitTest1
    {
        
        
        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void GetResult()
        {
            var result = controller.GetValue();
            Assert.Equal("DevOpsTest",result.Value);

        }

        [Fact]
        public void Test1()
        {

        }
    }
}
