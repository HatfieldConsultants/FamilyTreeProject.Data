//******************************************
//  Copyright (C) 2014-2015 Charles Nurse  *
//                                         *
//  Licensed under MIT License             *
//  (see included LICENSE)                 *
//                                         *
// *****************************************

// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable once CheckNamespace
namespace FamilyTreeProject.Data.EntityFramework.Common
{
    /// <summary>
    /// The BaseEntity class provides a base class for Family Tree Entities
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Constructs a Base Entity
        /// </summary>
        /// <param name="treeId">The Id of the Tree</param>
        protected BaseEntity(string treeId)
        {
            Id = string.Empty;
            TreeId = treeId;
        }

        /// <summary>
        ///   Gets or sets the id of the individual
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// This property indicates whether the entity is New
        /// </summary>
        public bool IsNew
        {
            get { return string.IsNullOrEmpty(Id); }
        }

        /// <summary>
        /// The Id of the Tree to which this entity belongs
        /// </summary>
        public string TreeId { get; set; }
    }
}
