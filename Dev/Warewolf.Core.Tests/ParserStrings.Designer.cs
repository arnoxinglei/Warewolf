﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Warewolf.Core.Tests{
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ParserStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ParserStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Warewolf.Core.Tests.ParserStrings", typeof(ParserStrings).Assembly);
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
        ///   Looks up a localized string similar to C:\Users\Massimo.Guerrera\Desktop\File_Tools_ActivityNames.txt.
        /// </summary>
        internal static string PathOperations_FileSystem_Path {
            get {
                return ResourceManager.GetString("PathOperations_FileSystem_Path", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ftp://rsaklfsvrpdc:1001/GET_DATA/file1.txt.
        /// </summary>
        internal static string PathOperations_FTP_Path {
            get {
                return ResourceManager.GetString("PathOperations_FTP_Path", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ftps://dev2ftps.dev2.local.
        /// </summary>
        internal static string PathOperations_FTPS_AuthPath {
            get {
                return ResourceManager.GetString("PathOperations_FTPS_AuthPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;Service ID=&quot;3fd60bce-f56c-46cf-95ca-346ccc668570&quot; Version=&quot;1.0&quot; ServerID=&quot;51a58300-7e9d-4927-a57b-e5d700b11b55&quot; Name=&quot;Bug9304&quot; ResourceType=&quot;WorkflowService&quot;&gt;
        ///	&lt;DisplayName&gt;Bug9304&lt;/DisplayName&gt;
        ///	&lt;Category&gt;Bugs&lt;/Category&gt;
        ///	&lt;IsNewWorkflow&gt;false&lt;/IsNewWorkflow&gt;
        ///	&lt;AuthorRoles/&gt;
        ///	&lt;Comment/&gt;
        ///	&lt;Tags/&gt;
        ///	&lt;IconPath&gt;pack://application:,,,/Dev2.Studio;component/images/workflowservice2.png&lt;/IconPath&gt;
        ///	&lt;HelpLink/&gt;
        ///	&lt;UnitTestTargetWorkflowService/&gt;
        ///	&lt;DataList&gt;
        ///		&lt;test Description=&quot;&quot; IsEditable=&quot;True&quot; ColumnIO [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string XamlLoaderBadNamespace {
            get {
                return ResourceManager.GetString("XamlLoaderBadNamespace", resourceCulture);
            }
        }
    }
}
