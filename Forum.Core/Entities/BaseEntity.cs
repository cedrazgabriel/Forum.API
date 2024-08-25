using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Core.Entities
{
    public abstract class BaseEntity<T>
    {
        private readonly UniqueEntityId _id;
        protected T Props { get; }

        public UniqueEntityId Id => _id;

        protected BaseEntity(T props, UniqueEntityId? id = null)
        {
            Props = props;
            _id = id ?? new UniqueEntityId();
        }
    }
}
