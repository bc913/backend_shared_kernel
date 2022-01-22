using Bcan.Backend.SharedKernel;
using System;
using System.Collections.Generic;

namespace Bcan.Backend.SharedKernel.Tests.Mocks
{
    public class ValueObjectMock : ValueObject
    {
        public ValueObjectMock(string name, int height, int width)
        {
            Name = name;
            Height = height;
            Width = width;
        }

        public string Name { get; private set; }
        public int Height { get; private set; }
        public int Width { get; private set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
            yield return Height;
            yield return Width;
        }
    }
}