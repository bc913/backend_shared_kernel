using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace Bcan.Backend.SharedKernel.Tests.EntityTests
{
    [TestClass]
    public class Constructor
    {
        [TestMethod]
        public void SucceedsForValidGuid()
        {
            var e = new Mocks.GuidEntity(Guid.NewGuid());
            e.Should().NotBeNull();
        }

        [TestMethod]
        public void SucceedsForValidInt()
        {
            var e = new Mocks.IntEntity(4);
            e.Should().NotBeNull();
        }

        [TestMethod]
        public void ThrowsForDefaultValuedGuid()
        {
            Action act = () => new Mocks.GuidEntity(Guid.Empty);
            act.Should().ThrowExactly<ArgumentException>();
        }

        [TestMethod]
        public void ThrowsForDefaultValuedIntId()
        {
            Action act = () => new Mocks.IntEntity(default(int));
            act.Should().ThrowExactly<ArgumentException>();
        }
    }
}