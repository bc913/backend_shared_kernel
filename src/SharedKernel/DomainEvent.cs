using System;
using Mediator;

namespace Bcan.Backend.SharedKernel
{
    public abstract class DomainEvent : INotification
    {
        public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;
    }
}