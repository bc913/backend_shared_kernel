using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bcan.Backend.SharedKernel;

namespace Bcan.Backend.SharedKernel.Tests.DateTimeRangeTests
{
    [TestClass]
    public class NewDuration
    {
        [TestMethod]
        public void ReturnsNewObjectWithGivenDuration()
        {
            var dtr = new DateTimeRange(DateTimes.TestDateTime, TimeSpan.FromHours(1));
            var newDtr = dtr.NewDuration(TimeSpan.FromHours(2));

            dtr.Should().NotBeSameAs(newDtr);
            newDtr.DurationInMinutes().Should().Be(120);
        }
    }
}
