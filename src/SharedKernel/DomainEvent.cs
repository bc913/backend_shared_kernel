using System;
using MediatR;

namespace Bcan.Backend.SharedKernel
{
    public abstract class DomainEvent : INotification
    {
        protected DomainEvent()
        {
            DateOccurred = DateTimeOffset.UtcNow;
        }

        #region Fields & Properties
        public DateTimeOffset DateOccurred 
        { 
            get; 
            protected set;
        } = DateTimeOffset.UtcNow;

        public bool IsPublished { get; set; }

        #endregion
    }
}