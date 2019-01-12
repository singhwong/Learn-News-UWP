﻿#pragma checksum "D:\gitUWP\Learn-News-UWP\Views\NewsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "42EDD667A19F8A76452C91FF98A10B8A"
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
    partial class NewsPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        private class NewsPage_obj15_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            INewsPage_Bindings
        {
            private global::The_Paper.Models.News dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Image obj16;
            private global::Windows.UI.Xaml.Controls.TextBlock obj17;
            private global::Windows.UI.Xaml.Controls.TextBlock obj18;
            private global::Windows.UI.Xaml.Controls.TextBlock obj19;
            private global::Windows.UI.Xaml.Controls.TextBlock obj20;

            public NewsPage_obj15_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 16:
                        this.obj16 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 17:
                        this.obj17 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 18:
                        this.obj18 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 19:
                        this.obj19 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 20:
                        this.obj20 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::The_Paper.Models.News data = args.NewValue as global::The_Paper.Models.News;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::The_Paper.Models.News was expected.");
                 }
                 this.SetDataRoot(data);
                 this.Update();
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(args.Item as global::The_Paper.Models.News);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.Grid)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::The_Paper.Models.News) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
            }

            // INewsPage_Bindings

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

            // NewsPage_obj15_Bindings

            public void SetDataRoot(global::The_Paper.Models.News newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::The_Paper.Models.News obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_image(obj.image, phase);
                        this.Update_headLine(obj.headLine, phase);
                        this.Update_mainContent(obj.mainContent, phase);
                        this.Update_tag(obj.tag, phase);
                        this.Update_time(obj.time, phase);
                    }
                }
            }
            private void Update_image(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj16, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
            private void Update_headLine(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj17, obj, null);
                }
            }
            private void Update_mainContent(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj18, obj, null);
                }
            }
            private void Update_tag(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj19, obj, null);
                }
            }
            private void Update_time(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj20, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.News_Page = (global::Windows.UI.Xaml.Controls.Page)(target);
                }
                break;
            case 2:
                {
                    this.Grid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3:
                {
                    this.row_1 = (global::Windows.UI.Xaml.Controls.RowDefinition)(target);
                }
                break;
            case 4:
                {
                    this.colume_1 = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 5:
                {
                    this.colume_2 = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 6:
                {
                    this.VisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 7:
                {
                    this.Narrow = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 8:
                {
                    this.Wide = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 9:
                {
                    this.back_button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 75 "..\..\..\Views\NewsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.back_button).Click += this.Back_button_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.TabView = (global::The_Paper.Controls.TabView)(target);
                    #line 78 "..\..\..\Views\NewsPage.xaml"
                    ((global::The_Paper.Controls.TabView)this.TabView).TabSwitch += this.TabView_TabSwitch;
                    #line default
                }
                break;
            case 11:
                {
                    this.NewsDetail = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 12:
                {
                    this.scrollViewer = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                    #line 82 "..\..\..\Views\NewsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ScrollViewer)this.scrollViewer).ViewChanged += this.ScrollViewer_ViewChanged;
                    #line default
                }
                break;
            case 13:
                {
                    this.topNews = (global::Windows.UI.Xaml.Controls.GridViewItem)(target);
                    #line 87 "..\..\..\Views\NewsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.GridViewItem)this.topNews).Tapped += this.topNews_Tapped;
                    #line default
                }
                break;
            case 14:
                {
                    this.NewsCards = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    #line 145 "..\..\..\Views\NewsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.GridView)this.NewsCards).ItemClick += this.NewsCards_ItemClick;
                    #line default
                }
                break;
            case 21:
                {
                    this.topNews_grid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 22:
                {
                    this.topNewsImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 23:
                {
                    this.topNews_stackPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 24:
                {
                    this.topNewsHL = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 25:
                {
                    this.topNewsMC = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 26:
                {
                    this.topNewsTag = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 27:
                {
                    this.topNewsSplit = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 28:
                {
                    this.topNewsTime = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 15:
                {
                    global::Windows.UI.Xaml.Controls.Grid element15 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    NewsPage_obj15_Bindings bindings = new NewsPage_obj15_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::The_Paper.Models.News) element15.DataContext);
                    element15.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element15, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

