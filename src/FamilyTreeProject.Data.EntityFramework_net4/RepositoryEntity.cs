//******************************************
//  Copyright (C) 2014-2015 Charles Nurse  *
//                                         *
//  Licensed under MIT License             *
//  (see included LICENSE)                 *
//                                         *
// *****************************************

using FamilyTreeProject.Data.EntityFramework.Common;

// ReSharper disable once CheckNamespace
namespace FamilyTreeProject.Data.EntityFramework
{
    /// <summary>
    /// The Repository class represents a repository of Family Tree information (this could be a website or a library for example)
    /// </summary>
    public class RepositoryEntity : Entity
    {
        public RepositoryEntity() : base(string.Empty) { }

        public RepositoryEntity(string treeId) : base(treeId) { }

        /// <summary>
        /// The Address of the Repository
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// The Name of the Repository
        /// </summary>
        public string Name { get; set; }
    }
}
