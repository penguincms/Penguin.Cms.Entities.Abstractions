using System;

namespace Penguin.Entities.Abstractions
{
    /// <summary>
    /// An interface containing information for an entity that changes over time, and is auditable
    /// </summary>
    public interface IAuditableEntity : IEntity
    {
        /// <summary>
        /// The last time this object was modified
        /// </summary>
        DateTime? DateModified { get; }
    }
}
