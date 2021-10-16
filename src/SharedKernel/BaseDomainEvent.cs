using System;

namespace Bcan.Backend.SharedKernel
{
    public abstract class BaseDomainEvent
    {
        public DateTimeOffset DateOccurred 
        { 
            get; 
            protected set; 
        } = DateTimeOffset.UtcNow;
    }
}