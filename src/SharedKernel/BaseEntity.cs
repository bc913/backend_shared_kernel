using System;

namespace Bcan.Backend.SharedKernel
{
    public abstract class BaseEntity<IdType> : IEquatable<BaseEntity<IdType>>
    {
        protected BaseEntity(IdType id)
        {
            if(object.Equals(id, default(IdType)))
                throw new ArgumentException("The id cannot be default value.");

            this._id = id;
        }

        #region Fields & Properties

        private readonly IdType _id;
        public IdType Id => this._id;

        #endregion
        
        #region IEquatable
        public bool Equals(BaseEntity<IdType> other)
        {
            if(other is null)
                return false;
            
            if(ReferenceEquals(this, other))
                return true;

            return this.Id.Equals(other.Id);
        }

        public override bool Equals(object other)
        {
            return other is BaseEntity<IdType> be && Equals(be);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode() ^ 31; //XOR for random distribution
        }

        public static bool operator ==(BaseEntity<IdType> lhs, BaseEntity<IdType> rhs)
        {
            if(lhs is null)
                return rhs is null;

            return lhs.Equals(rhs);
        }

        public static bool operator !=(BaseEntity<IdType> lhs, BaseEntity<IdType> rhs)
        {
            return !(lhs == rhs);
        }
        #endregion
    }
}