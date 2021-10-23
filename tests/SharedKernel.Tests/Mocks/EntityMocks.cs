using System;

namespace Bcan.Backend.SharedKernel.Tests.Mocks
{
    public class GuidEntity : Entity<Guid>
    {
        public GuidEntity(Guid id) : base(id){}
    }

    public class IntEntity : Entity<int>
    {
        public IntEntity(int id) : base(id) {}
    }
}