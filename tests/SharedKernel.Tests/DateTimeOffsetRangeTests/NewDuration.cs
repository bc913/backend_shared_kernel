using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bcan.Backend.SharedKernel;

namespace Bcan.Backend.SharedKernel.Tests.DateTimeOffsetRangeTests
{
    [TestClass]
    public class NewDuration
    {
        [TestMethod]
        public void ReturnsNewObjectWithGivenDuration()
        {
            var dtor = new DateTimeOffsetRange(DateTimeOffsets.TestValue, TimeSpan.FromHours(1));
            var newDtor = dtor.NewDuration(TimeSpan.FromHours(2));

            dtor.Should().NotBeSameAs(newDtor);
            newDtor.DurationInMinutes().Should().Be(120);
        }
    }
}
