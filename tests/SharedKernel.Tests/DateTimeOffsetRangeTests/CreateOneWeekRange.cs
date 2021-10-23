using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bcan.Backend.SharedKernel;

namespace Bcan.Backend.SharedKernel.Tests.DateTimeOffsetRangeTests
{
    [TestClass]
    public class CreateOneWeekRange
    {
        [TestMethod]
        public void CreatesRangeWithStartDateLastingSevenDay()
        {
            var dtor = DateTimeOffsetRange.CreateOneWeekRange(DateTimeOffsets.TestValue);

            dtor.Start.Should().Be(DateTimeOffsets.TestValue);
            dtor.End.Should().Be(dtor.Start.AddDays(7));
        }
    }
}
