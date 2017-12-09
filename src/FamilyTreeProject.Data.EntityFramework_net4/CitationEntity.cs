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
    /// Citation is a class that represents a source citation
    /// </summary>
    public class CitationEntity : OwnedEntity
    {
        public CitationEntity() : base(string.Empty) { }

        public CitationEntity(string treeId) : base(treeId) { }

        /// <summary>
        /// The Date of the Citation
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// The page number of the citation within the Source
        /// </summary>
        public string Page { get; set; }

        /// <summary>
        /// The Id of the Source to which the citation is a part
        /// </summary>
        public string SourceId { get; set; }

        /// <summary>
        /// The Source to which the citation belongs
        /// </summary>
        public SourceEntity Source { get; set; }

        /// <summary>
        /// The text of the citation
        /// </summary>
        public string Text { get; set; }
    }
}
