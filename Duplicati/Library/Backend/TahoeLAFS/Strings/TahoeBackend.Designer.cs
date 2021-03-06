﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.237
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Duplicati.Library.Backend.Strings {
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
    internal class TahoeBackend {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TahoeBackend() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Duplicati.Library.Backend.Strings.TahoeBackend", typeof(TahoeBackend).Assembly);
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
        ///   Looks up a localized string similar to This backend can read and write data to a Tahoe-LAFS based backend. Allowed format is &quot;tahoe://hostname:port/uri/$DIRCAP&quot;..
        /// </summary>
        internal static string Description {
            get {
                return ResourceManager.GetString("Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use this flag to communicate using Secure Socket Layer (SSL) over http (https)..
        /// </summary>
        internal static string DescriptionUseSSLLong {
            get {
                return ResourceManager.GetString("DescriptionUseSSLLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Instructs Duplicati to use an SSL (https) connection.
        /// </summary>
        internal static string DescriptionUseSSLShort {
            get {
                return ResourceManager.GetString("DescriptionUseSSLShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tahoe-LAFS based.
        /// </summary>
        internal static string Displayname {
            get {
                return ResourceManager.GetString("Displayname", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The folder {0} was not found, message: {1}.
        /// </summary>
        internal static string MissingFolderError {
            get {
                return ResourceManager.GetString("MissingFolderError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Found the Json fragment {0} but expected {1}.
        /// </summary>
        internal static string UnexpectedJsonFragmentType {
            get {
                return ResourceManager.GetString("UnexpectedJsonFragmentType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported URL format, must start with &quot;/uri/URI:DIR2:&quot;.
        /// </summary>
        internal static string UnrecognizedUriError {
            get {
                return ResourceManager.GetString("UnrecognizedUriError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The supplied URL contains a query, which is not allowed.
        /// </summary>
        internal static string UriHasQueryError {
            get {
                return ResourceManager.GetString("UriHasQueryError", resourceCulture);
            }
        }
    }
}
