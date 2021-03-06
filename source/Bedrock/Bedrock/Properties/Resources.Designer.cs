﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bedrock.Properties {
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
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Bedrock.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot change the region name once is set. The current region name is &apos;{0}&apos;..
        /// </summary>
        public static string CannotChangeRegionNameException {
            get {
                return ResourceManager.GetString("CannotChangeRegionNameException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can&apos;t find name property for this control!.
        /// </summary>
        public static string CannotFindNameProperty {
            get {
                return ResourceManager.GetString("CannotFindNameProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; does not implement from IRegionBehavior..
        /// </summary>
        public static string CanOnlyAddTypesThatInheritIFromRegionBehavior {
            get {
                return ResourceManager.GetString("CanOnlyAddTypesThatInheritIFromRegionBehavior", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ConfigurationStore cannot contain a null value. .
        /// </summary>
        public static string ConfigurationStoreCannotBeNull {
            get {
                return ResourceManager.GetString("ConfigurationStoreCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At least one cyclic dependency has been found in the module catalog. Cycles in the module dependencies must be avoided..
        /// </summary>
        public static string CyclicDependencyFound {
            get {
                return ResourceManager.GetString("CyclicDependencyFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {1}: {2}. Priority: {3}. Timestamp:{0:u}..
        /// </summary>
        public static string DefaultDebugLoggerPattern {
            get {
                return ResourceManager.GetString("DefaultDebugLoggerPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {1}: {2}. Priority: {3}. Timestamp:{0:u}..
        /// </summary>
        public static string DefaultTextLoggerPattern {
            get {
                return ResourceManager.GetString("DefaultTextLoggerPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add dependency for unknown module {0}.
        /// </summary>
        public static string DependencyForUnknownModule {
            get {
                return ResourceManager.GetString("DependencyForUnknownModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A module declared a dependency on another module which is not declared to be loaded. Missing module(s): {0}.
        /// </summary>
        public static string DependencyOnMissingModule {
            get {
                return ResourceManager.GetString("DependencyOnMissingModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Directory {0} was not found..
        /// </summary>
        public static string DirectoryNotFound {
            get {
                return ResourceManager.GetString("DirectoryNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A duplicated module with name {0} has been found by the loader..
        /// </summary>
        public static string DuplicatedModule {
            get {
                return ResourceManager.GetString("DuplicatedModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A duplicated module group with name {0} has been found by the loader..
        /// </summary>
        public static string DuplicatedModuleGroup {
            get {
                return ResourceManager.GetString("DuplicatedModuleGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To use the UIThread option for subscribing, the EventAggregator must be constructed on the UI thread..
        /// </summary>
        public static string EventAggregatorNotConstructedOnUIThread {
            get {
                return ResourceManager.GetString("EventAggregatorNotConstructedOnUIThread", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to retrieve the module type {0} from the loaded assemblies.  You may need to specify a more fully-qualified type name..
        /// </summary>
        public static string FailedToGetType {
            get {
                return ResourceManager.GetString("FailedToGetType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception occurred while initializing module &apos;{0}&apos;. 
        ///    - The exception message was: {2}
        ///    - The Assembly that the module was trying to be loaded from was:{1}
        ///    Check the InnerException property of the exception for more information. If the exception occurred while creating an object in a DI container, you can exception.GetRootException() to help locate the root cause of the problem. 
        ///  .
        /// </summary>
        public static string FailedToLoadModule {
            get {
                return ResourceManager.GetString("FailedToLoadModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception occurred while initializing module &apos;{0}&apos;. 
        ///    - The exception message was: {1}
        ///    Check the InnerException property of the exception for more information. If the exception occurred 
        ///    while creating an object in a DI container, you can exception.GetRootException() to help locate the 
        ///    root cause of the problem. .
        /// </summary>
        public static string FailedToLoadModuleNoAssemblyInfo {
            get {
                return ResourceManager.GetString("FailedToLoadModuleNoAssemblyInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to load type for module {0}. 
        ///Error was: {1}..
        /// </summary>
        public static string FailedToRetrieveModule {
            get {
                return ResourceManager.GetString("FailedToRetrieveModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument must be a valid absolute Uri to an assembly file..
        /// </summary>
        public static string InvalidArgumentAssemblyUri {
            get {
                return ResourceManager.GetString("InvalidArgumentAssemblyUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Target of the IDelegateReference should be of type {0}..
        /// </summary>
        public static string InvalidDelegateRerefenceTypeException {
            get {
                return ResourceManager.GetString("InvalidDelegateRerefenceTypeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Module {0} depends on other modules that don&apos;t belong to the same group..
        /// </summary>
        public static string ModuleDependenciesNotMetInGroup {
            get {
                return ResourceManager.GetString("ModuleDependenciesNotMetInGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Module {0} was not found in the catalog..
        /// </summary>
        public static string ModuleNotFound {
            get {
                return ResourceManager.GetString("ModuleNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ModulePath cannot contain a null value or be empty.
        /// </summary>
        public static string ModulePathCannotBeNullOrEmpty {
            get {
                return ResourceManager.GetString("ModulePathCannotBeNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to load type &apos;{0}&apos; from assembly &apos;{1}&apos;..
        /// </summary>
        public static string ModuleTypeNotFound {
            get {
                return ResourceManager.GetString("ModuleTypeNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of this control should not be null!.
        /// </summary>
        public static string NameValueOfControlIsNull {
            get {
                return ResourceManager.GetString("NameValueOfControlIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is currently no moduleTypeLoader in the ModuleManager that can retrieve the specified module..
        /// </summary>
        public static string NoRetrieverCanRetrieveModule {
            get {
                return ResourceManager.GetString("NoRetrieverCanRetrieveModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception has occurred while trying to add a view to region &apos;{0}&apos;. 
        ///    - The most likely causing exception was was: &apos;{1}&apos;.
        ///    But also check the InnerExceptions for more detail or call .GetRootException(). .
        /// </summary>
        public static string OnViewRegisteredException {
            get {
                return ResourceManager.GetString("OnViewRegisteredException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The member access expression does not access a property..
        /// </summary>
        public static string PropertySupport_ExpressionNotProperty_Exception {
            get {
                return ResourceManager.GetString("PropertySupport_ExpressionNotProperty_Exception", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The expression is not a member access expression..
        /// </summary>
        public static string PropertySupport_NotMemberAccessExpression_Exception {
            get {
                return ResourceManager.GetString("PropertySupport_NotMemberAccessExpression_Exception", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The referenced property is a static property..
        /// </summary>
        public static string PropertySupport_StaticExpression_Exception {
            get {
                return ResourceManager.GetString("PropertySupport_StaticExpression_Exception", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Attach method cannot be called when Region property is null..
        /// </summary>
        public static string RegionBehaviorAttachCannotBeCallWithNullRegion {
            get {
                return ResourceManager.GetString("RegionBehaviorAttachCannotBeCallWithNullRegion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Region property cannot be set after Attach method has been called..
        /// </summary>
        public static string RegionBehaviorRegionCannotBeSetAfterAttach {
            get {
                return ResourceManager.GetString("RegionBehaviorRegionCannotBeSetAfterAttach", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The region being added already has a name of &apos;{0}&apos; and cannot be added to the region manager with a different name (&apos;{1}&apos;)..
        /// </summary>
        public static string RegionManagerWithDifferentNameException {
            get {
                return ResourceManager.GetString("RegionManagerWithDifferentNameException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The region name cannot be null or empty..
        /// </summary>
        public static string RegionNameCannotBeEmptyException {
            get {
                return ResourceManager.GetString("RegionNameCannotBeEmptyException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Region with the given name is already registered: {0}.
        /// </summary>
        public static string RegionNameExistsException {
            get {
                return ResourceManager.GetString("RegionNameExistsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This RegionManager does not contain a Region with the name &apos;{0}&apos;..
        /// </summary>
        public static string RegionNotFound {
            get {
                return ResourceManager.GetString("RegionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The region manager does not contain the {0} region..
        /// </summary>
        public static string RegionNotInRegionManagerException {
            get {
                return ResourceManager.GetString("RegionNotInRegionManagerException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to View already exists in region..
        /// </summary>
        public static string RegionViewExistsException {
            get {
                return ResourceManager.GetString("RegionViewExistsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to View with name &apos;{0}&apos; already exists in the region..
        /// </summary>
        public static string RegionViewNameExistsException {
            get {
                return ResourceManager.GetString("RegionViewNameExistsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Module {0} is marked for automatic initialization when the application starts, but it depends on modules that are marked as OnDemand initialization. To fix this error, mark the dependency modules for InitializationMode=WhenAvailable, or remove this validation by extending the ModuleCatalog class..
        /// </summary>
        public static string StartupModuleDependsOnAnOnDemandModule {
            get {
                return ResourceManager.GetString("StartupModuleDependsOnAnOnDemandModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided String argument {0} must not be null or empty..
        /// </summary>
        public static string StringCannotBeNullOrEmpty {
            get {
                return ResourceManager.GetString("StringCannotBeNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No BehaviorType with key &apos;{0}&apos; was registered..
        /// </summary>
        public static string TypeWithKeyNotRegistered {
            get {
                return ResourceManager.GetString("TypeWithKeyNotRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception occurred while trying to create region objects. 
        ///    - The most likely causing exception was: &apos;{0}&apos;.
        ///    But also check the InnerExceptions for more detail or call .GetRootException(). .
        /// </summary>
        public static string UpdateRegionException {
            get {
                return ResourceManager.GetString("UpdateRegionException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value must be of type ModuleInfo..
        /// </summary>
        public static string ValueMustBeOfTypeModuleInfo {
            get {
                return ResourceManager.GetString("ValueMustBeOfTypeModuleInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} not found..
        /// </summary>
        public static string ValueNotFound {
            get {
                return ResourceManager.GetString("ValueNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to View already exists in region..
        /// </summary>
        public static string ViewAlreadyExistsInRegion {
            get {
                return ResourceManager.GetString("ViewAlreadyExistsInRegion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The region does not contain the specified view..
        /// </summary>
        public static string ViewNotInRegionException {
            get {
                return ResourceManager.GetString("ViewNotInRegionException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to view can&apos;t be null.
        /// </summary>
        public static string ViewShouldNotBeNull {
            get {
                return ResourceManager.GetString("ViewShouldNotBeNull", resourceCulture);
            }
        }
    }
}
