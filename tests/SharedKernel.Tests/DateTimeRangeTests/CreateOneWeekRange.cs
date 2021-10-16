using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bcan.Backend.SharedKernel;

namespace Bcan.Backend.SharedKernel.Tests.DateTimeRangeTests
{
    [TestClass]
    public class CreateOneWeekRange
    {
      [TestMethod]
      public void CreatesRangeWithStartDateLastingSevenDay()
      {
        var dtr = DateTimeRange.CreateOneWeekRange(DateTimes.TestDateTime);

        dtr.Start.Should().Be(DateTimes.TestDateTime);
        dtr.End.Should().Be(dtr.Start.AddDays(7));
      }
    }
}
