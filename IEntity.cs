using System;

namespace Penguin.Entities.Abstractions
{
    /// <summary>
    /// An interface for the lowest intended top level objects used by the penguin stack of persistence
    /// </summary>
    public interface IEntity
    {
        #region Properties

        /// <summary>
        /// The intended key of the entity
        /// </summary>
        int _Id { get; }

        /// <summary>
        /// A Globally unique identifier for the entity
        /// </summary>
        Guid Guid { get; }

        #endregion Properties
    }
}