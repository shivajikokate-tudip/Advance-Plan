﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WaterSystem_Repository {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Database : global::System.Configuration.ApplicationSettingsBase {
        
        private static Database defaultInstance = ((Database)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Database())));
        
        public static Database Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=ROHINI-PC;Initial Catalog=WaterSupplier_System;User ID=sa;password=sh" +
            "ivajiraje")]
        public string ConnectionString {
            get {
                return ((string)(this["ConnectionString"]));
            }
        }
    }
}
