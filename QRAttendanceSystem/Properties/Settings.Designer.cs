﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QRAttendanceSystem.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("17W76_IJm6ixYQIf0vTg91q4F26c1nOdq62K5Ooxoql4")]
        public string GoogleSheet_SheetID {
            get {
                return ((string)(this["GoogleSheet_SheetID"]));
            }
            set {
                this["GoogleSheet_SheetID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Attendance!A2")]
        public string GoogleSheet_Range {
            get {
                return ((string)(this["GoogleSheet_Range"]));
            }
            set {
                this["GoogleSheet_Range"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public decimal GoogleSheet_Retries {
            get {
                return ((decimal)(this["GoogleSheet_Retries"]));
            }
            set {
                this["GoogleSheet_Retries"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0242C0436DAA4C241CA8A793764B7DFB50C223121BB844CF49BE670A3AF4DD18")]
        public string Admin_Password {
            get {
                return ((string)(this["Admin_Password"]));
            }
            set {
                this["Admin_Password"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("QR Attendance System by @Ajacence")]
        public string Admin_QRFlag {
            get {
                return ((string)(this["Admin_QRFlag"]));
            }
            set {
                this["Admin_QRFlag"] = value;
            }
        }
    }
}