//******************************************
//  Copyright (C) 2014-2015 Charles Nurse  *
//                                         *
//  Licensed under MIT License             *
//  (see included LICENSE)                 *
//                                         *
// *****************************************

// ReSharper disable ConvertPropertyToExpressionBody

using FamilyTreeProject.Data.EntityFramework.Common;

// ReSharper disable once CheckNamespace
namespace FamilyTreeProject.Data.EntityFramework
{
    /// <summary>
    /// Note is a class that represents a Note
    /// </summary>
    public class NoteEntity : OwnedEntity
    {
        public NoteEntity() : base(string.Empty) { }

        public NoteEntity(string treeId) : base(treeId) { }

        /// <summary>
        /// The text of the Note
        /// </summary>
        public string Text { get; set; }
    }
}