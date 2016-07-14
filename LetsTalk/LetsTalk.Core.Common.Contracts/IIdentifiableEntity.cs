using System;

namespace LetsTalk.Core.Common.Contracts
{
    public interface IIdentifiableEntity
    {
        Guid EntityId { get; set; }
    }
}