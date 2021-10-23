using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace Bcan.Backend.SharedKernel.Tests.EntityTests
{
    [TestClass]
    public class DomainEventsApi
    {
        [TestMethod]
        public void NoDomainEventsByDefault()
        {
            var e1 = new Mocks.GuidEntity(Guid.NewGuid());
            e1.DomainEvents.Should().BeNullOrEmpty();
        }

        [TestMethod]
        public void AddDomainEventSucceeds()
        {
            var e1 = new Mocks.GuidEntity(Guid.NewGuid());
            var de = new Mocks.DomainEventMock();

            e1.AddDomainEvent(de);
            e1.DomainEvents.Count.Should().Be(1);
        }

        [TestMethod]
        public void RemoveDomainEventSucceeds()
        {
             var e1 = new Mocks.GuidEntity(Guid.NewGuid());
            var de = new Mocks.DomainEventMock();

            e1.AddDomainEvent(de);
            e1.RemoveDomainEvent(de);

            e1.DomainEvents.Count.Should().Be(0);
        }

        [TestMethod]
        public void ClearDomainEventSucceeds()
        {
             var e1 = new Mocks.GuidEntity(Guid.NewGuid());
            var de = new Mocks.DomainEventMock();

            e1.AddDomainEvent(de);
            e1.ClearDomainEvents();

            e1.DomainEvents.Count.Should().Be(0);
        }
    }
}