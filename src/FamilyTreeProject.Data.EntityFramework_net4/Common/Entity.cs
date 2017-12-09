//******************************************
//  Copyright (C) 2014-2015 Charles Nurse  *
//                                         *
//  Licensed under MIT License             *
//  (see included LICENSE)                 *
//                                         *
// *****************************************

using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace FamilyTreeProject.Data.EntityFramework.Common
{
    /// <summary>
    /// Entities are the main objects in the Family Tree (represented by Records in GEDCOM),
    /// Individuals, Families, Sources and Repositories are entities.
    /// While not represented by records in GEDCOM Facts are also Entities (as they have Notes)
    /// </summary>
    public abstract class Entity : BaseEntity
    {
        /// <summary>
        /// Constructs an Entity.
        /// </summary>
        /// <param name="treeId">The Id of the Tree</param>
        protected Entity(string treeId) : base(treeId)
        {
            Multimedia = new List<MultimediaLinkEntity>();
            Notes = new List<NoteEntity>();
        }

        /// <summary>
        /// A list of Multimedia Links
        /// </summary>
        public IList<MultimediaLinkEntity> Multimedia { get; set; }

        /// <summary>
        /// A list of Notes
        /// </summary>
        public IList<NoteEntity> Notes { get; set; }
    }
}
