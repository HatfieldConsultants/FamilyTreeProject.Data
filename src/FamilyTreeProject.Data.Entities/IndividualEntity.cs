//******************************************
//  Copyright (C) 2014-2015 Charles Nurse  *
//                                         *
//  Licensed under MIT License             *
//  (see included LICENSE)                 *
//                                         *
// *****************************************

using System;
using System.Collections.Generic;
using FamilyTreeProject.Data.Entities.Common;

// ReSharper disable ConvertPropertyToExpressionBody

// ReSharper disable once CheckNamespace
namespace FamilyTreeProject.Data.Entities
{
    /// <summary>
    ///   Represents an individual in a family tree
    /// </summary>
    public class IndividualEntity : AncestorEntity
    {
        public IndividualEntity() : this(string.Empty) { }

        public IndividualEntity(string treeId) : base(treeId)
        {
            ImageId = -1;
        }

        /// <summary>
        ///   Gets or sets a reference to the <see cref = "IndividualEntity" /> object representing
        ///   this individual's father.
        ///   <seealso cref = "IndividualEntity" />
        /// </summary>
        public IndividualEntity Father { get; set; }

        /// <summary>
        ///   Gets or sets the id of this individual's father
        /// </summary>
        public string FatherId { get; set; }

        /// <summary>
        ///   Gets or sets the first name of the individual
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The Id of the image displayed on the main view
        /// </summary>
        public int ImageId { get; set; }

        /// <summary>
        ///   Gets or sets the last name of the individual
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        ///   Gets or sets a reference to the <see cref = "IndividualEntity" /> object representing
        ///   this individual's mother.
        ///   <seealso cref = "IndividualEntity" />
        /// </summary>
        public IndividualEntity Mother { get; set; }

        /// <summary>
        ///   Gets or sets the id of this individual's mother
        /// </summary>
        public string MotherId { get; set; }

        /// <summary>
        /// Gets or sets the name of this Individual
        /// </summary>
        public string Name
        {
            get { return String.Format("{0}, {1}", LastName, FirstName); }
        }

        /// <summary>
        ///   Gets or sets the Sex of this individual
        /// </summary>
        public Sex Sex { get; set; }

        /// <summary>
        ///   Gets or sets the Spouses of the Individual.
        /// </summary>
        public IList<IndividualEntity> Spouses { get; set; }

        /// <summary>
        /// Create a shallow copy of this individual
        /// </summary>
        /// <returns>An Individual</returns>
        public IndividualEntity Clone()
        {
            return new IndividualEntity
                        {
                            FatherId = FatherId,
                            FirstName = FirstName,
                            Id = Id,
                            ImageId = ImageId,
                            LastName = LastName,
                            MotherId = MotherId,
                            Sex = Sex,
                            TreeId = TreeId
                        }; 
        }
    }
}