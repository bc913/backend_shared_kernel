using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bcan.Backend.SharedKernel;

namespace Bcan.Backend.SharedKernel.Tests.DateTimeRangeTests
{
    [TestClass]
    public class NewStart
    {
        [TestMethod]
        public void ReturnsNewObjectWithGivenStartDate()
        {
            DateTime startTime = DateTimes.TestDateTime;
            DateTime newStartTime = startTime.AddHours(-1);

            var dtr = new DateTimeRange(startTime, TimeSpan.FromHours(1));
            var newDtr = dtr.NewStart(newStartTime);

            dtr.Should().NotBeSameAs(newDtr);
            newDtr.Start.Should().Be(newStartTime);
        }
    }
}
