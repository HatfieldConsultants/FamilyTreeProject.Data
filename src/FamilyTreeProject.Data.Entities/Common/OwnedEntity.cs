//******************************************
//  Copyright (C) 2014-2015 Charles Nurse  *
//                                         *
//  Licensed under MIT License             *
//  (see included LICENSE)                 *
//                                         *
// *****************************************

// ReSharper disable once CheckNamespace
namespace FamilyTreeProject.Data.Entities.Common
{
    public abstract class OwnedEntity : Entity
    {
        /// <summary>
        /// Constructs an OwnedEntity.
        /// </summary>
        /// <param name="treeId">The Id of the Tree</param>
        protected OwnedEntity(string treeId) : base(treeId) { }

        /// <summary>
        /// The Id of the owner entity
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// The type of the owner entity
        /// </summary>
        public EntityType OwnerType { get; set; }
    }
}
