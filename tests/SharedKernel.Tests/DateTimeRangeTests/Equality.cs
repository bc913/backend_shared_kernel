using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bcan.Backend.SharedKernel;

namespace Bcan.Backend.SharedKernel.Tests.DateTimeRangeTests
{
    [TestClass]
    public class Equality
    {
        [TestMethod]
        public void ReturnsTrueGivenSameStartEnd()
        {
          var dtr1 = new DateTimeRange(DateTimes.TestDateTime, TimeSpan.FromHours(1));
          var dtr2 = new DateTimeRange(DateTimes.TestDateTime, TimeSpan.FromHours(1));

          dtr1.Should().NotBeSameAs(dtr2);
          dtr1.Should().Equals(dtr2);
          dtr2.Should().Equals(dtr1);
          (dtr1 == dtr2).Should().BeTrue();
        }
    }
}
