using System;
using Xunit;

namespace dotnet
{
    public class Example
    {
        [Fact]
        public void PassesTestOne()
        {
            Assert.Equal(42, (21 + 21));
        }

      [Fact]
        public void PassesTestTwo()
        {
            Assert.Equal(99, (33 * 3));
        }

      [Fact(Skip="skips test nine")]
        public void SkipsTestNine()
        {
            Assert.Equal(42, 99);
        }
    }
}
