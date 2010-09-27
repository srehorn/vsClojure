﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading;

namespace Microsoft.ClojureExtension {
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
    internal sealed class Resources
    {
        #region Constants
        internal const string Application = "Application";
        internal const string ApplicationCaption = "ApplicationCaption";
        internal const string GeneralCaption = "GeneralCaption";
        internal const string AssemblyName = "AssemblyName";
        internal const string AssemblyNameDescription = "AssemblyNameDescription";
        internal const string OutputType = "OutputType";
        internal const string OutputTypeDescription = "OutputTypeDescription";
        internal const string DefaultNamespace = "DefaultNamespace";
        internal const string DefaultNamespaceDescription = "DefaultNamespaceDescription";
        internal const string StartupObject = "StartupObject";
        internal const string StartupObjectDescription = "StartupObjectDescription";
        internal const string ApplicationIcon = "ApplicationIcon";
        internal const string ApplicationIconDescription = "ApplicationIconDescription";
        internal const string Project = "Project";
        internal const string ProjectFile = "ProjectFile";
        internal const string ProjectFileDescription = "ProjectFileDescription";
        internal const string ProjectFolder = "ProjectFolder";
        internal const string ProjectFolderDescription = "ProjectFolderDescription";
        internal const string OutputFile = "OutputFile";
        internal const string OutputFileDescription = "OutputFileDescription";
        internal const string TargetFrameworkMoniker = "TargetFrameworkMoniker";
        internal const string TargetFrameworkMonikerDescription = "TargetFrameworkMonikerDescription";
        internal const string NestedProjectFileAssemblyFilter = "NestedProjectFileAssemblyFilter";
        internal const string ClojureFrameworkPath = "ClojureFrameworkPath";
        internal const string ClojureFrameworkPathDescription = "ClojureFrameworkPath";
        //internal const string MsgFailedToLoadTemplateFile = "Failed to add template file to project";
        #endregion Constants

        #region Fields
        private static Resources loader;
        private ResourceManager resourceManager;
        private static Object internalSyncObjectInstance;
        #endregion Fields

        #region Constructors
        /// <summary>
        /// Internal explicitly defined default constructor.
        /// </summary>
        internal Resources()
        {
            resourceManager = new System.Resources.ResourceManager("Microsoft.ClojureExtension.Resources",
                Assembly.GetExecutingAssembly());
        }
        #endregion Constructors

        #region Properties
        /// <summary>
        /// Gets the internal sync. object.
        /// </summary>
        private static Object InternalSyncObject
        {
            get
            {
                if (internalSyncObjectInstance == null)
                {
                    Object o = new Object();
                    Interlocked.CompareExchange(ref internalSyncObjectInstance, o, null);
                }
                return internalSyncObjectInstance;
            }
        }
        /// <summary>
        /// Gets information about a specific culture.
        /// </summary>
        private static CultureInfo Culture
        {
            get { return null/*use ResourceManager default, CultureInfo.CurrentUICulture*/; }
        }

        /// <summary>
        /// Gets convenient access to culture-specific resources at runtime.
        /// </summary>
        public static ResourceManager ResourceManager
        {
            get
            {
                return GetLoader().resourceManager;
            }
        }
        #endregion Properties

        #region Public Implementation
        /// <summary>
        /// Provide access to resource string value.
        /// </summary>
        /// <param name="name">Received string name.</param>
        /// <param name="args">Arguments for the String.Format method.</param>
        /// <returns>Returns resources string value or null if error occured.</returns>
        public static string GetString(string name, params object[] args)
        {
            Resources resourcesInstance = GetLoader();
            if (resourcesInstance == null)
            {
                return null;
            }
            string res = resourcesInstance.resourceManager.GetString(name, Resources.Culture);

            if (args != null && args.Length > 0)
            {
                return String.Format(CultureInfo.CurrentCulture, res, args);
            }
            else
            {
                return res;
            }
        }
        /// <summary>
        /// Provide access to resource string value.
        /// </summary>
        /// <param name="name">Received string name.</param>
        /// <returns>Returns resources string value or null if error occured.</returns>
        public static string GetString(string name)
        {
            Resources resourcesInstance = GetLoader();

            if (resourcesInstance == null)
            {
                return null;
            }
            return resourcesInstance.resourceManager.GetString(name, Resources.Culture);
        }

        /// <summary>
        /// Provide access to resource object value.
        /// </summary>
        /// <param name="name">Received object name.</param>
        /// <returns>Returns resources object value or null if error occured.</returns>
        public static object GetObject(string name)
        {
            Resources resourcesInstance = GetLoader();

            if (resourcesInstance == null)
            {
                return null;
            }
            return resourcesInstance.resourceManager.GetObject(name, Resources.Culture);
        }
        #endregion Methods

        private static Resources GetLoader()
        {
            if (loader == null)
            {
                lock (InternalSyncObject)
                {
                    if (loader == null)
                    {
                        loader = new Resources();
                    }
                }
            }
            return loader;
        }
    }
}