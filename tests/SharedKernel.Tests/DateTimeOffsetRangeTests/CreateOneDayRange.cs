using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace Bcan.Backend.SharedKernel.Tests.DateTimeOffsetRangeTests
{
    [TestClass]
    public class CreateOneDayRange
    {
        [TestMethod]
        public void CreatesRangeWithStartDateLastingOneDay()
        {
            var dtor = DateTimeOffsetRange.CreateOneDayRange(DateTimeOffsets.TestValue);

            dtor.Start.Should().Be(DateTimeOffsets.TestValue);
            dtor.End.Should().Be(dtor.Start.AddDays(1));
        }
    }
}
