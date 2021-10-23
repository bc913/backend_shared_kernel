using System;
using System.Collections.Generic;
using System.Linq;

namespace Bcan.Backend.SharedKernel
{
    public abstract class ValueObject : IEquatable<ValueObject>
    {
        protected abstract IEnumerable<object> GetEqualityComponents();

        #region IEquatable
        public override bool Equals(object obj)
        {
            return obj is ValueObject vo && base.Equals(vo);
        }
        public bool Equals(ValueObject other)
        {
            if(other is null)
                return false;
            
            if(ReferenceEquals(this, other))
                return true;

            return GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());            
        }
        public override int GetHashCode()
        {
            // https://docs.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/implement-value-objects
            /*
             return GetEqualityComponents()
                .Select(x => x != null ? x.GetHashCode() : 0)
                .Aggregate((x, y) => x ^ y);
            */
            return GetEqualityComponents()
                .Aggregate(1, (current, obj) =>
                {
                    unchecked
                    {
                        return current * 23 + (obj?.GetHashCode() ?? 0);
                    }
                });
        }

        public static bool operator==(ValueObject lhs, ValueObject rhs)
        {
            if(lhs is null)
                return rhs is null;

            return lhs.Equals(rhs);
        }

        public static bool operator!=(ValueObject lhs, ValueObject rhs)
        {
            return !(lhs == rhs);
        }
        #endregion

        public ValueObject ShallowCopy()
        {
            return this.MemberwiseClone() as ValueObject;
        }
    }
}