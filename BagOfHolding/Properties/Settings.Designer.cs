﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BagOfHolding.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.1.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color consoleBackColor {
            get {
                return ((global::System.Drawing.Color)(this["consoleBackColor"]));
            }
            set {
                this["consoleBackColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("InactiveBorder")]
        public global::System.Drawing.Color consoleForeColor {
            get {
                return ((global::System.Drawing.Color)(this["consoleForeColor"]));
            }
            set {
                this["consoleForeColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DarkSlateBlue")]
        public global::System.Drawing.Color windowContColor {
            get {
                return ((global::System.Drawing.Color)(this["windowContColor"]));
            }
            set {
                this["windowContColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("230, 100, 100")]
        public global::System.Drawing.Color windowButtColor {
            get {
                return ((global::System.Drawing.Color)(this["windowButtColor"]));
            }
            set {
                this["windowButtColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("255, 255, 128")]
        public global::System.Drawing.Color windowToolColor {
            get {
                return ((global::System.Drawing.Color)(this["windowToolColor"]));
            }
            set {
                this["windowToolColor"] = value;
            }
        }
    }
}
