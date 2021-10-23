using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bcan.Backend.SharedKernel;

namespace Bcan.Backend.SharedKernel.Tests.DateTimeOffsetRangeTests
{
    [TestClass]
    public class DurationInMinutes
    {
        [TestMethod]
        public void Returns60GivenOneHourDifference()
        {
            var dtor = new DateTimeOffsetRange(DateTimeOffsets.TestValue, TimeSpan.FromHours(1));
            dtor.DurationInMinutes().Should().Be(60);
        }
    }
}
