using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bcan.Backend.SharedKernel;

namespace Bcan.Backend.SharedKernel.Tests.DateTimeOffsetRangeTests
{
    [TestClass]
    public class Overlaps
    {
        [TestMethod]
        public void ReturnsTrueForGivenSameDateTimeOffsetRange()
        {
            var dtr = new DateTimeOffsetRange(DateTimeOffsets.TestValue, TimeSpan.FromHours(1));
            var result = dtr.Overlaps(dtr);
            result.Should().BeTrue();
        }

        [TestMethod]
        public void ReturnsTrueGivenEarlierRangeExceedingStart()
        {
            var dtr = new DateTimeOffsetRange(DateTimeOffsets.TestValue, TimeSpan.FromHours(1));
            var earlier = new DateTimeOffsetRange(DateTimeOffsets.TestValue.AddMinutes(-5), TimeSpan.FromMinutes(10));

            var result = dtr.Overlaps(earlier);
            result.Should().BeTrue();
        }

        [TestMethod]
        public void ReturnsTrueGivenRangeWithinRange()
        {
            var dtr = new DateTimeOffsetRange(DateTimeOffsets.TestValue, TimeSpan.FromHours(1));
            var within = new DateTimeOffsetRange(DateTimeOffsets.TestValue.AddMinutes(5), TimeSpan.FromMinutes(10));

            var result = dtr.Overlaps(within);
            result.Should().BeTrue();
        }

        [TestMethod]
        public void ReturnsTrueGivenRangeStartingWithinRangeEndingLater()
        {
            var dtr = new DateTimeOffsetRange(DateTimeOffsets.TestValue, TimeSpan.FromHours(1));
            var endslater = new DateTimeOffsetRange(dtr.End.AddMinutes(-5), TimeSpan.FromMinutes(10));

            var result = dtr.Overlaps(endslater);
            result.Should().BeTrue();
        }

        [TestMethod]
        public void ReturnsFalseGivenRangeEndingBeforeStart()
        {
            var dtr = new DateTimeOffsetRange(DateTimeOffsets.TestValue, TimeSpan.FromHours(1));
            var endsearlier = new DateTimeOffsetRange(dtr.Start.AddHours(-1), TimeSpan.FromMinutes(10));

            var result = dtr.Overlaps(endsearlier);
            result.Should().BeFalse();
        }

        [TestMethod]
        public void ReturnsFalseGivenRangeStartingAfterEnd()
        {
            var dtr = new DateTimeOffsetRange(DateTimeOffsets.TestValue, TimeSpan.FromHours(1));
            var startslater = new DateTimeOffsetRange(dtr.End.AddMinutes(1), TimeSpan.FromMinutes(10));

            var result = dtr.Overlaps(startslater);
            result.Should().BeFalse();
        }
    }
}
