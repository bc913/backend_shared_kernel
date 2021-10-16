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
        public void ReturnsNewObjectWithGivenEndDate()
        {
          DateTime newStartTime = DateTimes.TestDateTime.AddHours(-1);
          var dtr = new DateTimeRange(DateTimes.TestDateTime, TimeSpan.FromHours(1));

          var newDtr = dtr.NewStart(newStartTime);

          dtr.Should().NotBeSameAs(newDtr);
          newDtr.Start.Should().Be(newStartTime);
        }
    }
}
