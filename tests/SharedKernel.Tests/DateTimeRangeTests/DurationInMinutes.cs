using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bcan.Backend.SharedKernel;

namespace Bcan.Backend.SharedKernel.Tests.DateTimeRangeTests
{
    [TestClass]
    public class DurationInMinutes
    {
        [TestMethod]
        public void Returns60GivenOneHourDifference()
        {
            var dtr = new DateTimeRange(DateTimes.TestDateTime, TimeSpan.FromHours(1));
            dtr.DurationInMinutes().Should().Be(60);
        }
    }
}
