﻿

//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.



namespace ARQ.Maqueta.Entities.Properties {
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
    internal class SqlServerScripts {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SqlServerScripts() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ARQ.Maqueta.Entities.Properties.SqlServerScripts", typeof(SqlServerScripts).Assembly);
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
        ///   Looks up a localized string similar to ALTER TABLE [{0}].[{1}] ADD CONSTRAINT {2} UNIQUE ({3}).
        /// </summary>
        internal static string AddUniqueConstriantScript {
            get {
                return ResourceManager.GetString("AddUniqueConstriantScript", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to COMMIT TRANSACTION;
        ///                             END TRY
        ///                             BEGIN CATCH                            
        ///                              ROLLBACK TRANSACTION;
        ///                              DECLARE @ErrorMessage NVARCHAR(4000);
        ///                              DECLARE @ErrorSeverity INT;
        ///                              DECLARE @ErrorState INT;
        ///
        ///                              SELECT 
        ///                                @ErrorMessage = ERROR_MESSAGE(),
        ///                                @ErrorS [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CatchScript {
            get {
                return ResourceManager.GetString("CatchScript", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IF NOT EXISTS(SELECT 1 FROM SYSINDEXES WHERE NAME =&apos;{0}&apos;).
        /// </summary>
        internal static string CheckIfIndexExist {
            get {
                return ResourceManager.GetString("CheckIfIndexExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IF NOT EXISTS(SELECT 1 FROM SYS.OBJECTS WHERE NAME = &apos;{0}&apos; AND parent_object_id = OBJECT_ID(&apos;{1}&apos;)).
        /// </summary>
        internal static string CheckObjectExistScript {
            get {
                return ResourceManager.GetString("CheckObjectExistScript", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create NonClustered Index {0} On [{1}].[{2}] ({3}).
        /// </summary>
        internal static string CreateIndexScript {
            get {
                return ResourceManager.GetString("CreateIndexScript", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BEGIN TRY
        ///                            BEGIN TRANSACTION;.
        /// </summary>
        internal static string TryScript {
            get {
                return ResourceManager.GetString("TryScript", resourceCulture);
            }
        }
    }
}
