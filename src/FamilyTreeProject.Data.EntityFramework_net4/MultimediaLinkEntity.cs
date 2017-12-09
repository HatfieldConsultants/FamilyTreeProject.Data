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
    /// MultimediaLink is a class that represents a Link to multimedia content
    /// </summary>
    public class MultimediaLinkEntity : OwnedEntity
    {
        public MultimediaLinkEntity() : base(string.Empty) { }

        public MultimediaLinkEntity(string treeId) : base(treeId) { }

		/// <summary>
        /// The file path (or Uri)
        /// </summary>
		public string File { get; set; }

		/// <summary>
        /// The type of the multimedia (jpg, mp3 etc)
        /// </summary>
		public string Format { get; set; }

		/// <summary>
        /// The title of the Multimedia
        /// </summary>
		public string Title { get; set; }
    }
}
