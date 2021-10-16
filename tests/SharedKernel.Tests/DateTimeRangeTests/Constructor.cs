using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using Bcan.Backend.SharedKernel;

namespace Bcan.Backend.SharedKernel.Tests.DateTimeRangeTests
{
    [TestClass]
    public class Constructor
    {
      [TestMethod]
      public void ThrowsGivenStartAfterEnd()
      {
            Action act = () => 
              new DateTimeRange(DateTimes.TestDateTime, DateTimes.TestDateTime.AddDays(-1));

            act.Should().ThrowExactly<ArgumentException>();
      }

      [TestMethod]
      public void ThrowsGivenStartAndNegativeTimeSpan()
      {
        TimeSpan span = new TimeSpan(-1, 0, 0);
            Action act = () => new DateTimeRange(DateTimes.TestDateTime, span);
            act.Should().ThrowExactly<ArgumentException>();
      }
    }
}
