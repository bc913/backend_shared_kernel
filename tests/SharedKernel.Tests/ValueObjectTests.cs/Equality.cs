using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace Bcan.Backend.SharedKernel.Tests.ValueObjectTests
{
    [TestClass]
    public class Equality
    {
        [TestMethod]
        public void ShouldReturnTrueForSameReference()
        {
            var vo1 = new Mocks.ValueObjectMock("Dummy", 43, 45);
            var vo2 = vo1;

            vo1.Should().Be(vo2);
            vo2.Should().Be(vo1);
            (vo1 == vo2).Should().BeTrue();

            vo1.Should().Equals(vo2);
            vo2.Should().Equals(vo1);

            // They are pointing the same reference
            vo1.Should().BeSameAs(vo2);
            vo2.Should().BeSameAs(vo1);

            vo1.Equals(vo2).Should().BeTrue();
            vo2.Equals(vo1).Should().BeTrue();

            Object.Equals(vo1, vo2).Should().BeTrue();
            Object.Equals(vo2, vo1).Should().BeTrue();
        }

        [TestMethod]
        public void SameValuedInstancesShouldBeEqual()
        {
            var name = "Test Name";
            var height = 23;
            var width = 34;

            var vo1 = new Mocks.ValueObjectMock(name, height, width);
            var vo2 = new Mocks.ValueObjectMock(name, height, width);

            vo1.Should().Be(vo2);
            vo2.Should().Be(vo1);
            (vo1 == vo2).Should().BeTrue();

            vo1.Should().Equals(vo2);
            vo2.Should().Equals(vo1);

            // they are not pointing the same reference
            vo1.Should().NotBeSameAs(vo2);
            vo2.Should().NotBeSameAs(vo1);

            vo1.Equals(vo2).Should().BeTrue();
            vo2.Equals(vo1).Should().BeTrue();

            Object.Equals(vo1, vo2).Should().BeTrue();
            Object.Equals(vo2, vo1).Should().BeTrue();
        }

        [TestMethod]
        public void DifferentValuedInstancesShouldNotBeEqual()
        {
            var vo1 = new Mocks.ValueObjectMock("Test", 34, 45);
            var vo2 = new Mocks.ValueObjectMock("Test1", 34, 45);

            vo1.Should().NotBe(vo2);
            vo2.Should().NotBe(vo1);
            (vo1 == vo2).Should().BeFalse();
            (vo1 != vo2).Should().BeTrue();

            // different references
            vo1.Should().NotBeSameAs(vo2);
            vo2.Should().NotBeSameAs(vo1);

            vo1.Equals(vo2).Should().BeFalse();
            vo2.Equals(vo1).Should().BeFalse();

            Object.Equals(vo1, vo2).Should().BeFalse();
            Object.Equals(vo2, vo1).Should().BeFalse();
        }
    }
}