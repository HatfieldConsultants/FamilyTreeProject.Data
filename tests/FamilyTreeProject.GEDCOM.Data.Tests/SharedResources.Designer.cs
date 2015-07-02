﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FamilyTreeProject.GEDCOM.Data.Tests {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SharedResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SharedResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FamilyTreeProject.GEDCOM.Data.Tests.SharedResources", typeof(SharedResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data Source={0};Integrated Security=True.
        /// </summary>
        internal static string AdminConnectionString {
            get {
                return ResourceManager.GetString("AdminConnectionString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data Source={0};Integrated Security=True;Initial Catalog={1}.
        /// </summary>
        internal static string ConnectionString {
            get {
                return ResourceManager.GetString("ConnectionString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If (SELECT COUNT(*) FROM sys.databases WHERE [name] = &apos;{0}&apos;) &gt; 0
        ///	DROP DATABASE [{0}]
        ///
        ///CREATE DATABASE [{0}].
        /// </summary>
        internal static string CreateDatabase {
            get {
                return ResourceManager.GetString("CreateDatabase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT COUNT(*) FROM sys.databases WHERE [name] = &apos;{0}&apos;.
        /// </summary>
        internal static string DatabaseCount {
            get {
                return ResourceManager.GetString("DatabaseCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to FamilyTreeProject_Test.
        /// </summary>
        internal static string DatabaseName {
            get {
                return ResourceManager.GetString("DatabaseName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DROP DATABASE [{0}].
        /// </summary>
        internal static string DropDatabase {
            get {
                return ResourceManager.GetString("DropDatabase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test.ged.
        /// </summary>
        internal static string GEDCOMFileName {
            get {
                return ResourceManager.GetString("GEDCOMFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to C:\GitHub\Personal\FamilyTreeProject.Data\tests\FamilyTreeProject.GEDCOM.Data.Tests\TestFiles.
        /// </summary>
        internal static string GEDCOMTestFilePath {
            get {
                return ResourceManager.GetString("GEDCOMTestFilePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to FamilyTreeProject.Integration.Tests.
        /// </summary>
        internal static string Namespace {
            get {
                return ResourceManager.GetString("Namespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT COUNT(*) FROM sys.objects WHERE [name] = &apos;{0}&apos;.
        /// </summary>
        internal static string ObjectCount {
            get {
                return ResourceManager.GetString("ObjectCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT COUNT(*) FROM {0}.
        /// </summary>
        internal static string RecordCount {
            get {
                return ResourceManager.GetString("RecordCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT COUNT(*) FROM {0}.
        /// </summary>
        internal static string RecordCountScript {
            get {
                return ResourceManager.GetString("RecordCountScript", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (local).
        /// </summary>
        internal static string ServerName {
            get {
                return ResourceManager.GetString("ServerName", resourceCulture);
            }
        }
    }
}
