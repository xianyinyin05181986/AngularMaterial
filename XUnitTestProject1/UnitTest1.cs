using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Throws(typeof(InvalidOperationException), () => { throw new InvalidOperationException(); });
        }

        public void unit()
        {
            throw new InvalidOperationException();
        }

        [Fact]
        public void Test2()
        {
        }
    }
}
