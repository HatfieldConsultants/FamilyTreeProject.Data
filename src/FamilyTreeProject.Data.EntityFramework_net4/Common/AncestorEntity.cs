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
    public abstract class AncestorEntity : Entity
    {
        protected AncestorEntity(string treeId) : base(treeId)
        {
            Children = new List<IndividualEntity>();
            Facts = new List<FactEntity>();
            Citations = new List<CitationEntity>();
        }

        /// <summary>
        ///   Gets or sets the Children of the Ancestor (Individual/Family).
        /// </summary>
        public IList<IndividualEntity> Children { get; set; }

        /// <summary>
        ///   Gets or sets the Citations for the Ancestor (Individual/Family)
        /// </summary>
        public IList<CitationEntity> Citations { get; set; }

        /// <summary>
        ///   Gets or sets the Facts of the Ancestor (Individual/Family).
        /// </summary>
        public IList<FactEntity> Facts { get; set; }
    }
}
