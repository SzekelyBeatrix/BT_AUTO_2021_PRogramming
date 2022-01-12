
using NUnit_Auto_2022;
using System;
using Xunit;
using Xunit.Abstractions;

namespace XUnit_Auto_2022
{
    public class UnitTest1 : IDisposable
    { 

    private readonly ITestOutputHelper testOutputHelper;
    
    public UnitTest1(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
            testOutputHelper.WriteLine("Setup method!");
        }
        public void Dispose()
        {
            Console.WriteLine("TearDown!!");
        }
    
        [Fact]
        public void Test1()
        {
            testOutputHelper.WriteLine("My test");
            Calculator c = new Calculator(50, 100, '-');
            Assert.Equal(-50, c.Compute());
        }
      
    }
}
