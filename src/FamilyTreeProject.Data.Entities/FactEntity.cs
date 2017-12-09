//******************************************
//  Copyright (C) 2014-2015 Charles Nurse  *
//                                         *
//  Licensed under MIT License             *
//  (see included LICENSE)                 *
//                                         *
// *****************************************

using System.Collections.Generic;
using FamilyTreeProject.Data.Entities.Common;

// ReSharper disable once CheckNamespace
namespace FamilyTreeProject.Data.Entities
{
    /// <summary>
    /// Fact is a class that represents a generic Fact (or attribute in GEDCOM)
    /// </summary>
    public class FactEntity : OwnedEntity
    {
        public FactEntity() : this(string.Empty) { }

        public FactEntity(string treeId) : base(treeId)
        {
            Citations = new List<CitationEntity>();
        }

        /// <summary>
        ///   Gets or sets the Citations for the Fact
        /// </summary>
        public IList<CitationEntity> Citations { get; set; }

        /// <summary>
        /// The date of the fact (if the fact is an event)
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// The type of the Fact
        /// </summary>
        public FactType FactType { get; set; }

        /// <summary>
        /// The place for the fact
        /// </summary>
        public string Place { get; set; }
    }
}