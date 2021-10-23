using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace Bcan.Backend.SharedKernel.Tests.DateTimeOffsetRangeTests
{
    [TestClass]
    public class Constructor
    {
        [TestMethod]
        public void ShouldThrowForGivenStartAfterEnd()
        {
            Action act = () =>
                new DateTimeOffsetRange(
                    DateTimeOffsets.TestValue,
                    DateTimeOffsets.TestValue.AddDays(-1));

            act.Should().ThrowExactly<ArgumentException>();
        }

        [TestMethod]
        public void ShouldThrowForValidStartAndNegativeTimeSpan()
        {
            TimeSpan span = new TimeSpan(-1, 0, 0);
            Action act = () => new DateTimeOffsetRange(DateTimeOffsets.TestValue, span);
            act.Should().ThrowExactly<ArgumentException>();
        }
    }
}
