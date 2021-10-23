using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bcan.Backend.SharedKernel;

namespace Bcan.Backend.SharedKernel.Tests.DateTimeOffsetRangeTests
{
    [TestClass]
    public class NewStart
    {
        [TestMethod]
        public void ReturnsNewObjectWithGivenStartDate()
        {
            var startTime = DateTimeOffsets.TestValue;
            var newStartTime = startTime.AddHours(-1);

            var dtor = new DateTimeOffsetRange(startTime, TimeSpan.FromHours(1));
            var newDtor = dtor.NewStart(newStartTime);

            dtor.Should().NotBeSameAs(newDtor);
            newDtor.Start.Should().Be(newStartTime);
        }
    }
}
