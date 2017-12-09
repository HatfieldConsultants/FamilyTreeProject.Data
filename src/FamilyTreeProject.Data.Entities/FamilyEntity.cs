//******************************************
//  Copyright (C) 2014-2015 Charles Nurse  *
//                                         *
//  Licensed under MIT License             *
//  (see included LICENSE)                 *
//                                         *
// *****************************************

using FamilyTreeProject.Data.Entities.Common;

// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable once CheckNamespace
namespace FamilyTreeProject.Data.Entities
{
    /// <summary>
    /// Family is a class that represents a family of ancestors
    /// </summary>
    public class FamilyEntity : AncestorEntity
    {
        public FamilyEntity() : base(string.Empty) { }

        public FamilyEntity(string treeId) : base(treeId) { }

        /// <summary>
        ///   Gets or sets a reference to the <see cref = "IndividualEntity" /> object representing
        ///   this family's husband.
        ///   <seealso cref = "IndividualEntity" />
        /// </summary>
        public IndividualEntity Husband { get; set; }

        /// <summary>
        ///   Gets or sets the id of this family's husband
        /// </summary>
        public string HusbandId { get; set; }

        /// <summary>
        ///   Gets or sets a reference to the <see cref = "IndividualEntity" /> object representing
        ///   this family's wife.
        ///   <seealso cref = "IndividualEntity" />
        /// </summary>
        public IndividualEntity Wife { get; set; }

        /// <summary>
        ///   Gets or sets the id of this family's wife
        /// </summary>
        public string WifeId { get; set; }

        /// <summary>
        /// Create a shallow copy of this individual
        /// </summary>
        /// <returns>An Individual</returns>
        public FamilyEntity Clone()
        {
            return new FamilyEntity
            {
                HusbandId = HusbandId,
                Id = Id,
                WifeId = WifeId,
                TreeId = TreeId
            };
        }

    }
}