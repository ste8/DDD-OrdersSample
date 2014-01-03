using System;

namespace DddOrdersSample.Core.Infrastructure
{
    public abstract class BaseId<T>
    {
        public T Id { get; set; }

        protected BaseId(T id)
        {
            Id = id;
        }
    }

    public abstract class BaseGuidId : BaseId<Guid>
    {
        protected BaseGuidId()
            : base(Guid.NewGuid())
        {
        }

        protected BaseGuidId(Guid id)
            : base(id)
        {
        }
    }

    public abstract class BaseStringId : BaseId<string>
    {
        protected BaseStringId(string id)
            : base(id)
        {
        }
    }
}