using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bcan.Backend.SharedKernel;

namespace Bcan.Backend.SharedKernel.Tests.DateTimeRangeTests
{
    [TestClass]
    public class NewEnd
    {
        [TestMethod]
        public void ReturnsNewObjectWithGivenEndDate()
        {
          DateTime newEndTime = DateTimes.TestDateTime.AddHours(2);
          var dtr = new DateTimeRange(DateTimes.TestDateTime, TimeSpan.FromHours(1));

          var newDtr = dtr.NewEnd(newEndTime);

          dtr.Should().NotBeSameAs(newDtr);
          newDtr.End.Should().Be(newEndTime);
        }
    }
}
