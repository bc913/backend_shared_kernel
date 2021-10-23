using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace Bcan.Backend.SharedKernel.Tests.EntityTests
{
    [TestClass]
    public class Equality
    {
        [TestMethod]
        public void ReturnsTrueForSameReferences()
        {
            var e1 = new Mocks.GuidEntity(Guid.NewGuid());
            var e2 = e1;
            
            e1.Should().BeSameAs(e2);
            e2.Should().BeSameAs(e1);

            e1.Should().Equals(e2);
            e2.Should().Equals(e1);

            (e1 == e2).Should().BeTrue();
        }

        [TestMethod]
        public void ReturnsTrueForSameId()
        {
            var e1 = new Mocks.IntEntity(5);
            var e2 = new Mocks.IntEntity(5);
            
            e1.Should().NotBeSameAs(e2);
            e2.Should().NotBeSameAs(e1);

            e1.Should().Equals(e2);
            e2.Should().Equals(e1);
            
            (e1 == e2).Should().BeTrue();
        }

        [TestMethod]
        public void ReturnsFalseForDifferentReferences()
        {
            var e1 = new Mocks.GuidEntity(Guid.NewGuid());
            var e2 = new Mocks.GuidEntity(Guid.NewGuid());
            
            e1.Should().NotBeSameAs(e2);
            e2.Should().NotBeSameAs(e1);

            (e1.Equals(e2)).Should().BeFalse();
            (e2.Equals(e1)).Should().BeFalse();

            (e1 != e2).Should().BeTrue();
        }

        [TestMethod]
        public void ReturnsFalseForGivenNull()
        {
            var e1 = new Mocks.GuidEntity(Guid.NewGuid());
            (e1.Equals(null)).Should().BeFalse();
        }
    }
}