﻿#pragma checksum "C:\Users\singh\Documents\GitHub\Learn-News-UWP\Views\SettingPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "749384636C82BAA1BB6E011DFACCD478"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace The_Paper.Views
{
    partial class SettingPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_FontIcon_FontWeight(global::Windows.UI.Xaml.Controls.FontIcon obj, global::Windows.UI.Text.FontWeight value)
            {
                obj.FontWeight = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class SettingPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISettingPage_Bindings
        {
            private global::The_Paper.Views.SettingPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.FontIcon obj6;
            private global::Windows.UI.Xaml.Controls.FontIcon obj7;
            private global::Windows.UI.Xaml.Controls.FontIcon obj8;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj6FontWeightDisabled = false;
            private static bool isobj7FontWeightDisabled = false;
            private static bool isobj8FontWeightDisabled = false;

            public SettingPage_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 93 && columnNumber == 85)
                {
                    isobj6FontWeightDisabled = true;
                }
                else if (lineNumber == 77 && columnNumber == 85)
                {
                    isobj7FontWeightDisabled = true;
                }
                else if (lineNumber == 59 && columnNumber == 85)
                {
                    isobj8FontWeightDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 6: // Views\SettingPage.xaml line 93
                        this.obj6 = (global::Windows.UI.Xaml.Controls.FontIcon)target;
                        break;
                    case 7: // Views\SettingPage.xaml line 77
                        this.obj7 = (global::Windows.UI.Xaml.Controls.FontIcon)target;
                        break;
                    case 8: // Views\SettingPage.xaml line 59
                        this.obj8 = (global::Windows.UI.Xaml.Controls.FontIcon)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                throw new global::System.NotImplementedException();
            }

            public void Recycle()
            {
                throw new global::System.NotImplementedException();
            }

            // ISettingPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::The_Paper.Views.SettingPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::The_Paper.Views.SettingPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_FontWeight(obj.FontWeight, phase);
                    }
                }
            }
            private void Update_FontWeight(global::Windows.UI.Text.FontWeight obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\SettingPage.xaml line 93
                    if (!isobj6FontWeightDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_FontIcon_FontWeight(this.obj6, obj);
                    }
                    // Views\SettingPage.xaml line 77
                    if (!isobj7FontWeightDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_FontIcon_FontWeight(this.obj7, obj);
                    }
                    // Views\SettingPage.xaml line 59
                    if (!isobj8FontWeightDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_FontIcon_FontWeight(this.obj8, obj);
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // Views\SettingPage.xaml line 1
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                }
                break;
            case 2: // Views\SettingPage.xaml line 49
                {
                    this.email_button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.email_button).Click += this.Email_button_Click;
                }
                break;
            case 3: // Views\SettingPage.xaml line 66
                {
                    this.comment_button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.comment_button).Click += this.Comment_button_Click;
                }
                break;
            case 4: // Views\SettingPage.xaml line 83
                {
                    this.more_button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.more_button).Tapped += this.More_button_Tapped;
                }
                break;
            case 5: // Views\SettingPage.xaml line 103
                {
                    this.setting_toggleSwitch = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.setting_toggleSwitch).Toggled += this.Setting_toggleSwitch_Toggled;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\SettingPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    SettingPage_obj1_Bindings bindings = new SettingPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

