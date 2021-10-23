using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
namespace Bcan.Backend.SharedKernel.Tests.DateTimeRangeTests
{
    [TestClass]
    public class Constructor
    {
        [TestMethod]
        public void ShouldThrowForGivenStartAfterEnd()
        {
            Action act = () =>
                new DateTimeRange(DateTimes.TestDateTime, DateTimes.TestDateTime.AddDays(-1));

            act.Should().ThrowExactly<ArgumentException>();
        }

        [TestMethod]
        public void ShouldThrowForValidStartAndNegativeTimeSpan()
        {
            TimeSpan span = new TimeSpan(-1, 0, 0);
            Action act = () => new DateTimeRange(DateTimes.TestDateTime, span);
            act.Should().ThrowExactly<ArgumentException>();
        }
    }
}
