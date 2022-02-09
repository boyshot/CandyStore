using System;
using System.Collections.Generic;
using CandyStore.Core.Messages;

namespace CandyStore.Core.Domain
{
    public abstract class Entity
    {
        public Guid Id { get; set; }

        private readonly ListEventNotify _listEventNotify;

        public IReadOnlyCollection<Event> ListReadNotify => _listEventNotify.ListReadNotify;

        protected Entity()
        {
            Id = Guid.NewGuid();
            _listEventNotify = new ListEventNotify();
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Entity;

            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;

            return Id.Equals(compareTo.Id);
        }

        public static bool operator ==(Entity a, Entity b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(Entity a, Entity b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }

        public override string ToString()
        {
            return $"{GetType().Name} [Id={Id}]";
        }

        public virtual bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}