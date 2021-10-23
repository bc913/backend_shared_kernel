using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using FluentAssertions.Extensions;

namespace Bcan.Backend.SharedKernel.Tests.BaseDomainEventTests
{
    public class EventMock : DomainEvent { }

    [TestClass]
    public class Constructor
    {
        [TestMethod]
        public void InitializesTimeToCurrentTime()
        {
            var newEvent = new EventMock();            
            newEvent.DateOccurred.Should().BeCloseTo(DateTime.UtcNow, 100.Milliseconds());
        }
    }
}