using System;
using Xunit;

namespace XUnit_Auto_2022
{
    public class UnitTest1 : IDisposable
    { 

    private readonly ITestOutputHelper testOutputhelper;
    
    public UnitTest1(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
            testOutputHelper.WriteLine("Setup method!");
        }
        public void Dispose()
        {
            Console.WriteLine();
        }
    
        [Fact]
        public void Test1()
        {

        }
        public void Setup()
        { 
        }
    }
}
