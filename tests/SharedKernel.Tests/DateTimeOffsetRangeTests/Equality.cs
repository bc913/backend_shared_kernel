using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bcan.Backend.SharedKernel;

namespace Bcan.Backend.SharedKernel.Tests.DateTimeOffsetRangeTests
{
    [TestClass]
    public class Equality
    {
        [TestMethod]
        public void ReturnsTrueForSameRefInstances()
        {
            var dtr1 = new DateTimeOffsetRange(DateTimeOffsets.TestValue, TimeSpan.FromDays(1));
            var dtr2 = dtr1;

            dtr1.Should().BeSameAs(dtr2);
        }

        [TestMethod]
        public void ReturnsTrueForSameValueInstances()
        {
            var dtr1 = new DateTimeOffsetRange(DateTimeOffsets.TestValue, TimeSpan.FromDays(1));
            var dtr2 = new DateTimeOffsetRange(DateTimeOffsets.TestValue, TimeSpan.FromDays(1));

            dtr1.Should().NotBeSameAs(dtr2);
            dtr1.Should().Equals(dtr2);
            dtr2.Should().Equals(dtr1);
            (dtr1 == dtr2).Should().BeTrue();
        }

        [TestMethod]
        public void ReturnsFalseForDifferentValueInstances()
        {
            var dtr1 = new DateTimeOffsetRange(DateTimeOffsets.TestValue, TimeSpan.FromDays(1));
            var dtr2 = new DateTimeOffsetRange(DateTimeOffsets.TestValue, TimeSpan.FromDays(2));

            dtr1.Should().NotBeSameAs(dtr2);
            (dtr1.Equals(dtr2)).Should().BeFalse();
            (dtr2.Equals(dtr1)).Should().BeFalse();
            (dtr1 != dtr2).Should().BeTrue();
        }
    }
}
