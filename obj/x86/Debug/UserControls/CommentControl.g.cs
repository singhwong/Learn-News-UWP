﻿#pragma checksum "D:\gitUWP\Learn-News-UWP\UserControls\CommentControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8E2442ECC36E0547EFAF5D18661B2F96"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace The_Paper.UserControls
{
    partial class CommentControl : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Media_ImageBrush_ImageSource(global::Windows.UI.Xaml.Media.ImageBrush obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.ImageSource = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class CommentControl_obj7_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ICommentControl_Bindings
        {
            private global::The_Paper.Models.Comment dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj7;
            private global::Windows.UI.Xaml.Controls.TextBlock obj8;
            private global::Windows.UI.Xaml.Controls.TextBlock obj9;
            private global::Windows.UI.Xaml.Controls.ListView obj10;
            private global::Windows.UI.Xaml.Controls.TextBlock obj11;
            private global::Windows.UI.Xaml.Media.ImageBrush obj13;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj8TextDisabled = false;
            private static bool isobj9TextDisabled = false;
            private static bool isobj10ItemsSourceDisabled = false;
            private static bool isobj11TextDisabled = false;
            private static bool isobj13ImageSourceDisabled = false;

            public CommentControl_obj7_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 75 && columnNumber == 36)
                {
                    isobj8TextDisabled = true;
                }
                else if (lineNumber == 76 && columnNumber == 36)
                {
                    isobj9TextDisabled = true;
                }
                else if (lineNumber == 79 && columnNumber == 54)
                {
                    isobj10ItemsSourceDisabled = true;
                }
                else if (lineNumber == 91 && columnNumber == 36)
                {
                    isobj11TextDisabled = true;
                }
                else if (lineNumber == 71 && columnNumber == 49)
                {
                    isobj13ImageSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 7: // UserControls\CommentControl.xaml line 67
                        this.obj7 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.RelativePanel)target);
                        break;
                    case 8: // UserControls\CommentControl.xaml line 75
                        this.obj8 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 9: // UserControls\CommentControl.xaml line 76
                        this.obj9 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 10: // UserControls\CommentControl.xaml line 79
                        this.obj10 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    case 11: // UserControls\CommentControl.xaml line 91
                        this.obj11 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 13: // UserControls\CommentControl.xaml line 71
                        this.obj13 = (global::Windows.UI.Xaml.Media.ImageBrush)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj7.Target as global::Windows.UI.Xaml.Controls.RelativePanel).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::The_Paper.Models.Comment) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // ICommentControl_Bindings

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
                    this.dataRoot = (global::The_Paper.Models.Comment)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::The_Paper.Models.Comment obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_userName(obj.userName, phase);
                        this.Update_time(obj.time, phase);
                        this.Update_commentFloors(obj.commentFloors, phase);
                        this.Update_content(obj.content, phase);
                        this.Update_avatarSrc(obj.avatarSrc, phase);
                    }
                }
            }
            private void Update_userName(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // UserControls\CommentControl.xaml line 75
                    if (!isobj8TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj8, obj, null);
                    }
                }
            }
            private void Update_time(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // UserControls\CommentControl.xaml line 76
                    if (!isobj9TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj9, obj, null);
                    }
                }
            }
            private void Update_commentFloors(global::System.Collections.Generic.List<global::The_Paper.Models.CommentFloor> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // UserControls\CommentControl.xaml line 79
                    if (!isobj10ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj10, obj, null);
                    }
                }
            }
            private void Update_content(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // UserControls\CommentControl.xaml line 91
                    if (!isobj11TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj11, obj, null);
                    }
                }
            }
            private void Update_avatarSrc(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // UserControls\CommentControl.xaml line 71
                    if (!isobj13ImageSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Media_ImageBrush_ImageSource(this.obj13, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class CommentControl_obj14_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ICommentControl_Bindings
        {
            private global::The_Paper.Models.Comment dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj14;
            private global::Windows.UI.Xaml.Controls.TextBlock obj15;
            private global::Windows.UI.Xaml.Controls.TextBlock obj16;
            private global::Windows.UI.Xaml.Controls.ListView obj17;
            private global::Windows.UI.Xaml.Controls.TextBlock obj18;
            private global::Windows.UI.Xaml.Media.ImageBrush obj20;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj15TextDisabled = false;
            private static bool isobj16TextDisabled = false;
            private static bool isobj17ItemsSourceDisabled = false;
            private static bool isobj18TextDisabled = false;
            private static bool isobj20ImageSourceDisabled = false;

            public CommentControl_obj14_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 36 && columnNumber == 36)
                {
                    isobj15TextDisabled = true;
                }
                else if (lineNumber == 37 && columnNumber == 36)
                {
                    isobj16TextDisabled = true;
                }
                else if (lineNumber == 40 && columnNumber == 35)
                {
                    isobj17ItemsSourceDisabled = true;
                }
                else if (lineNumber == 52 && columnNumber == 36)
                {
                    isobj18TextDisabled = true;
                }
                else if (lineNumber == 32 && columnNumber == 49)
                {
                    isobj20ImageSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 14: // UserControls\CommentControl.xaml line 28
                        this.obj14 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.RelativePanel)target);
                        break;
                    case 15: // UserControls\CommentControl.xaml line 36
                        this.obj15 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 16: // UserControls\CommentControl.xaml line 37
                        this.obj16 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 17: // UserControls\CommentControl.xaml line 40
                        this.obj17 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    case 18: // UserControls\CommentControl.xaml line 52
                        this.obj18 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 20: // UserControls\CommentControl.xaml line 32
                        this.obj20 = (global::Windows.UI.Xaml.Media.ImageBrush)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj14.Target as global::Windows.UI.Xaml.Controls.RelativePanel).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::The_Paper.Models.Comment) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // ICommentControl_Bindings

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
                    this.dataRoot = (global::The_Paper.Models.Comment)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::The_Paper.Models.Comment obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_userName(obj.userName, phase);
                        this.Update_time(obj.time, phase);
                        this.Update_commentFloors(obj.commentFloors, phase);
                        this.Update_content(obj.content, phase);
                        this.Update_avatarSrc(obj.avatarSrc, phase);
                    }
                }
            }
            private void Update_userName(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // UserControls\CommentControl.xaml line 36
                    if (!isobj15TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj15, obj, null);
                    }
                }
            }
            private void Update_time(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // UserControls\CommentControl.xaml line 37
                    if (!isobj16TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj16, obj, null);
                    }
                }
            }
            private void Update_commentFloors(global::System.Collections.Generic.List<global::The_Paper.Models.CommentFloor> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // UserControls\CommentControl.xaml line 40
                    if (!isobj17ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj17, obj, null);
                    }
                }
            }
            private void Update_content(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // UserControls\CommentControl.xaml line 52
                    if (!isobj18TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj18, obj, null);
                    }
                }
            }
            private void Update_avatarSrc(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // UserControls\CommentControl.xaml line 32
                    if (!isobj20ImageSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Media_ImageBrush_ImageSource(this.obj20, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
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
            case 2: // UserControls\CommentControl.xaml line 15
                {
                    this.RelativePanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3: // UserControls\CommentControl.xaml line 20
                {
                    this.Hot = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // UserControls\CommentControl.xaml line 23
                {
                    this.HotCommentBox = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                }
                break;
            case 5: // UserControls\CommentControl.xaml line 60
                {
                    this.New = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // UserControls\CommentControl.xaml line 62
                {
                    this.CommentBox = (global::Windows.UI.Xaml.Controls.ListBox)(target);
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
            case 7: // UserControls\CommentControl.xaml line 67
                {                    
                    global::Windows.UI.Xaml.Controls.RelativePanel element7 = (global::Windows.UI.Xaml.Controls.RelativePanel)target;
                    CommentControl_obj7_Bindings bindings = new CommentControl_obj7_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element7.DataContext);
                    element7.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element7, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element7, bindings);
                }
                break;
            case 14: // UserControls\CommentControl.xaml line 28
                {                    
                    global::Windows.UI.Xaml.Controls.RelativePanel element14 = (global::Windows.UI.Xaml.Controls.RelativePanel)target;
                    CommentControl_obj14_Bindings bindings = new CommentControl_obj14_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element14.DataContext);
                    element14.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element14, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element14, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

