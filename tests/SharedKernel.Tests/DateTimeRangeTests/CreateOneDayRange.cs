using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bcan.Backend.SharedKernel;

namespace Bcan.Backend.SharedKernel.Tests.DateTimeRangeTests
{
    [TestClass]
    public class CreateOneDayRange
    {
      [TestMethod]
      public void CreatesRangeWithStartDateLastingOneDay()
      {
        var dtr = DateTimeRange.CreateOneDayRange(DateTimes.TestDateTime);

        dtr.Start.Should().Be(DateTimes.TestDateTime);
        dtr.End.Should().Be(dtr.Start.AddDays(1));
      }
    }
}
