﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.237
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Duplicati.Library.Compression.Strings {
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
    internal class FileArchiveZip {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal FileArchiveZip() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Duplicati.Library.Compression.Strings.FileArchiveZip", typeof(FileArchiveZip).Assembly);
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
        ///   Looks up a localized string similar to Cannot read data while writing.
        /// </summary>
        internal static string AttemptReadWhileWritingError {
            get {
                return ResourceManager.GetString("AttemptReadWhileWritingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot write while reading.
        /// </summary>
        internal static string AttemptWriteWhileReadingError {
            get {
                return ResourceManager.GetString("AttemptWriteWhileReadingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This option controls the compression level used. A setting of zero gives no compression, and a setting of 9 gives maximum compression..
        /// </summary>
        internal static string CompressionlevelLong {
            get {
                return ResourceManager.GetString("CompressionlevelLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sets the Zip compression level.
        /// </summary>
        internal static string CompressionlevelShort {
            get {
                return ResourceManager.GetString("CompressionlevelShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Zip does not support deleting.
        /// </summary>
        internal static string DeleteUnsupportedError {
            get {
                return ResourceManager.GetString("DeleteUnsupportedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This module provides the industry standard Zip compression. Files created with this module can be read by any standard compliant zip application..
        /// </summary>
        internal static string Description {
            get {
                return ResourceManager.GetString("Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Zip compression.
        /// </summary>
        internal static string DisplayName {
            get {
                return ResourceManager.GetString("DisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File not found: {0}.
        /// </summary>
        internal static string FileNotFoundError {
            get {
                return ResourceManager.GetString("FileNotFoundError", resourceCulture);
            }
        }
    }
}
