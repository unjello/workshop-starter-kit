using System;
using Xunit;
using Workshop;

namespace Workshop.Tests
{
    public class Test_IsTrue
    {
        private readonly Test _test;

        public Test_IsTrue()
        {
            _test = new Test();
        }

        [Fact]
        public void ReturnTrue()
        {
            var result = _test.IsTrue();

            Assert.True(result, "Should be true");
        }
    }
}
