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
            var e = new Mocks.GuidEntity(){Id = Guid.NewGuid()};
            e.Should().NotBeNull();
        }

        [TestMethod]
        public void SucceedsForValidInt()
        {
            var e = new Mocks.IntEntity(){Id = 4};
            e.Should().NotBeNull();
        }

        [TestMethod]
        public void DefaultGuidCtor_ShouldGenerate_DefaultId()
        {
            var e = new Mocks.GuidEntity();
            e.Should().NotBeNull();
            e.Id.Should().Be(Guid.Empty);
        }

        [TestMethod]
        public void DefaultIntCtor_ShouldGenerate_DefaultId()
        {
            var e = new Mocks.IntEntity();
            e.Should().NotBeNull();
            e.Id.Should().Be(default(int));
        }
    }
}