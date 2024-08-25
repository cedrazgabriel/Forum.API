using System;

namespace Forum.Core.Entities
{
    public class UniqueEntityId
    {
        private readonly string _value;

        public UniqueEntityId(string? value = null)
        {
            _value = value ?? Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return _value;
        }

        public string ToValue()
        {
            return _value;
        }
    }
}
