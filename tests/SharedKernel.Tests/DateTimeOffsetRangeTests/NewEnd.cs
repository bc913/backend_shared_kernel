using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bcan.Backend.SharedKernel;

namespace Bcan.Backend.SharedKernel.Tests.DateTimeOffsetRangeTests
{
    [TestClass]
    public class NewEnd
    {
        [TestMethod]
        public void ReturnsNewObjectWithGivenEndDate()
        {
            var endTime = DateTimeOffsets.TestValue;
            var newEndTime = endTime.AddHours(2);

            var dtor = new DateTimeOffsetRange(endTime, TimeSpan.FromHours(1));
            var newDtor = dtor.NewEnd(newEndTime);

            dtor.Should().NotBeSameAs(newDtor);
            newDtor.End.Should().Be(newEndTime);
        }
    }
}
