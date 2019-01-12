﻿#pragma checksum "D:\gitUWP\Learn-News-UWP\Views\VideoPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "38FD2CDBA675F24E0533BBADEAF5864A"
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
    partial class VideoPage : 
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

        private class VideoPage_obj16_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IVideoPage_Bindings
        {
            private global::The_Paper.Models.Video dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Image obj17;
            private global::Windows.UI.Xaml.Controls.TextBlock obj18;
            private global::Windows.UI.Xaml.Controls.TextBlock obj19;
            private global::Windows.UI.Xaml.Controls.TextBlock obj20;
            private global::Windows.UI.Xaml.Controls.TextBlock obj21;

            public VideoPage_obj16_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 17:
                        this.obj17 = (global::Windows.UI.Xaml.Controls.Image)target;
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
                    case 21:
                        this.obj21 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::The_Paper.Models.Video data = args.NewValue as global::The_Paper.Models.Video;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::The_Paper.Models.Video was expected.");
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
                        this.SetDataRoot(args.Item as global::The_Paper.Models.Video);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.Grid)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::The_Paper.Models.Video) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
            }

            // IVideoPage_Bindings

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

            // VideoPage_obj16_Bindings

            public void SetDataRoot(global::The_Paper.Models.Video newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::The_Paper.Models.Video obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_imageSrc(obj.imageSrc, phase);
                        this.Update_headLine(obj.headLine, phase);
                        this.Update_mainContent(obj.mainContent, phase);
                        this.Update_tag(obj.tag, phase);
                        this.Update_time(obj.time, phase);
                    }
                }
            }
            private void Update_imageSrc(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj17, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
            private void Update_headLine(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj18, obj, null);
                }
            }
            private void Update_mainContent(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj19, obj, null);
                }
            }
            private void Update_tag(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj20, obj, null);
                }
            }
            private void Update_time(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj21, obj, null);
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
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    #line 14 "..\..\..\Views\VideoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_Loaded;
                    #line default
                }
                break;
            case 2:
                {
                    this.RootGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3:
                {
                    this.row_1 = (global::Windows.UI.Xaml.Controls.RowDefinition)(target);
                }
                break;
            case 4:
                {
                    this.back_button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 44 "..\..\..\Views\VideoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.back_button).Click += this.Back_button_Click;
                    #line default
                }
                break;
            case 5:
                {
                    global::The_Paper.Controls.TabView element5 = (global::The_Paper.Controls.TabView)(target);
                    #line 48 "..\..\..\Views\VideoPage.xaml"
                    ((global::The_Paper.Controls.TabView)element5).TabSwitch += this.TabView_TabSwitch;
                    #line default
                }
                break;
            case 6:
                {
                    this.main_ProgressRing = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 7:
                {
                    this.videoRow_1 = (global::Windows.UI.Xaml.Controls.RowDefinition)(target);
                }
                break;
            case 8:
                {
                    this.colume_2 = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 9:
                {
                    this.TopVideo = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 10:
                {
                    this.ScrollViewer = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                    #line 163 "..\..\..\Views\VideoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ScrollViewer)this.ScrollViewer).ViewChanged += this.ScrollViewer_ViewChanged;
                    #line default
                }
                break;
            case 11:
                {
                    this.VideoDetail_grid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 12:
                {
                    this.close_button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 322 "..\..\..\Views\VideoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.close_button).Click += this.Close_button_Click;
                    #line default
                }
                break;
            case 13:
                {
                    this.VideoDetail = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 14:
                {
                    this.VideoCards = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    #line 171 "..\..\..\Views\VideoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.GridView)this.VideoCards).ItemClick += this.VideoCards_ItemClick;
                    #line default
                }
                break;
            case 15:
                {
                    this.videoStatus_textblock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 22:
                {
                    this.TopThumb = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 23:
                {
                    this.mediaElement = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                    #line 154 "..\..\..\Views\VideoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MediaElement)this.mediaElement).PointerExited += this.mediaElement_PointerExited;
                    #line 155 "..\..\..\Views\VideoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MediaElement)this.mediaElement).PointerEntered += this.mediaElement_PointerEntered;
                    #line default
                }
                break;
            case 24:
                {
                    this.playButton = (global::Windows.UI.Xaml.Controls.FontIcon)(target);
                    #line 112 "..\..\..\Views\VideoPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.FontIcon)this.playButton).Tapped += this.playButton_Tapped;
                    #line default
                }
                break;
            case 25:
                {
                    this.topVideoHeadLine = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 26:
                {
                    this.topVideoLength = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 27:
                {
                    this.topVideo_stackPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 28:
                {
                    this.topVideoTag = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 29:
                {
                    this.topVideoTime = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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
            case 16:
                {
                    global::Windows.UI.Xaml.Controls.Grid element16 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    VideoPage_obj16_Bindings bindings = new VideoPage_obj16_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::The_Paper.Models.Video) element16.DataContext);
                    element16.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element16, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

