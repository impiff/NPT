﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DevExpress.XtraEditors;
using System.Configuration;
using System.Diagnostics;

namespace NPT.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.4.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {

        private static Settings defaultInstance = (Settings)SettingsBase.Synchronized((SettingsBase)new Settings());

        public static Settings Default => Settings.defaultInstance;

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("")]
        public string CustomDll
        {
            get => (string)this[nameof(CustomDll)];
            set => this[nameof(CustomDll)] = (object)value;
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("False")]
        public bool Advanced
        {
            get => (bool)this[nameof(Advanced)];
            set => this[nameof(Advanced)] = (object)value;
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("False")]
        public bool SaveOnClose
        {
            get => (bool)this[nameof(SaveOnClose)];
            set => this[nameof(SaveOnClose)] = (object)value;
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("False")]
        public bool AutoInject
        {
            get => (bool)this[nameof(AutoInject)];
            set => this[nameof(AutoInject)] = (object)value;
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public int AutoInjectDelaySeconds
        {
            get => (int)this[nameof(AutoInjectDelaySeconds)];
            set => this[nameof(AutoInjectDelaySeconds)] = (object)value;
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("False")]
        public bool HideSensitiveInfo
        {
            get => (bool)this[nameof(HideSensitiveInfo)];
            set => this[nameof(HideSensitiveInfo)] = (object)value;
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public int CurrentMenu
        {
            get => (int)this[nameof(CurrentMenu)];
            set => this[nameof(CurrentMenu)] = (object)value;
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1")]
        public string InjectDll
        {
            get => (string)this[nameof(InjectDll)];
            set => this[nameof(InjectDll)] = (object)value;
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("0")]
        public int GameLauncher
        {
            get => (int)this[nameof(GameLauncher)];
            set => this[nameof(GameLauncher)] = (object)value;
        }
    }
}
