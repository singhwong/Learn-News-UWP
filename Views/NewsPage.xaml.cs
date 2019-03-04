using System;
using System.Diagnostics;
using The_Paper.Models;
using The_Paper.ViewModels;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace The_Paper.Views
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class NewsPage : Page
    {
        NewsPageVM newsPageVM;

        public NewsPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //Window.Current.CoreWindow.KeyDown += CoreWindow_KeyDown;
            base.OnNavigatedTo(e);
            newsPageVM = new NewsPageVM((Channel)e.Parameter);
            this.DataContext = newsPageVM;
        }

        private async void TabView_TabSwitch(object sender, EventArgs e)
        {
            scrollViewer.ChangeView(null, 0, null);
            try
            {
                await newsPageVM.LoadTab((e as TabSwitchEventArgs).tabIndex);
            }
            catch
            {
            }

            #region 优化点击顶部标题烂选项，右边会出现 NewsDetail Page bug,尚不知为何会出现这种情况
            colume_2.Width = new GridLength(0);
            back_button.Visibility = Visibility.Collapsed;
            #endregion
        }

        private void ScrollViewer_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {
            if ((sender as ScrollViewer).VerticalOffset + (sender as ScrollViewer).ViewportHeight
                == (sender as ScrollViewer).ExtentHeight)
                newsPageVM.LoadMore();
        }

        private void topNews_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            //Grid.ColumnDefinitions.Clear();
            //Grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
            //Grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(2, GridUnitType.Star) });
            //NewsDetail.SetValue(Grid.ColumnProperty, 1);
            ad_control9.Visibility = Visibility.Collapsed;
            topNewsImage.Visibility = Visibility.Collapsed;
            topNewsHL.FontSize = 14;
            topNewsMC.FontSize = 13;
            topNewsTag.FontSize = 12;
            topNewsSplit.FontSize = 12;
            topNewsTime.FontSize = 12;
            colume_1.Width = new GridLength(230);
            back_button.Visibility = Visibility.Visible;
            row_1.Height = new GridLength(45);
            colume_2.Width = new GridLength(3, GridUnitType.Star);
            NewsDetail.Visibility = Visibility.Visible;
            newsPageVM.IsOpen = true;
            NewsDetail.Navigate(typeof(NewsDetailPage),
                (newsPageVM.TopNews.uri));
        }

        private void Back_button_Click(object sender, RoutedEventArgs e)
        {
            ad_control9.Visibility = Visibility.Visible;
            topNewsImage.Visibility = Visibility.Visible;
            topNewsHL.FontSize = 22;
            topNewsMC.FontSize = 16;
            topNewsTag.FontSize = 13;
            topNewsSplit.FontSize = 13;
            topNewsTime.FontSize = 13;
            colume_1.Width = new GridLength(1, GridUnitType.Star);
            colume_2.Width = new GridLength(0);
            back_button.Visibility = Visibility.Collapsed;
            newsPageVM.IsOpen = false;
            NewsDetail.Navigate(typeof(BlankPage));//导航到一个空白页，使非video页面，播放video时click关闭按钮，视频播放停止
            //(未找到该mediaElement控件，暂时用该方法实现停止播放)
        }

        private void NewsCards_ItemClick(object sender, ItemClickEventArgs e)
        {
            ad_control9.Visibility = Visibility.Collapsed;
            topNewsImage.Visibility = Visibility.Collapsed;
            topNewsHL.FontSize = 14;
            topNewsMC.FontSize = 13;
            topNewsTag.FontSize = 12;
            topNewsSplit.FontSize = 12;
            topNewsTime.FontSize = 12;
            colume_1.Width = new GridLength(230);
            back_button.Visibility = Visibility.Visible;
            colume_2.Width = new GridLength(3, GridUnitType.Star);
            NewsDetail.Visibility = Visibility.Visible;
            newsPageVM.IsOpen = true;
            NewsDetail.Navigate(typeof(NewsDetailPage),
                ((News)(e.ClickedItem))?.uri);
        }

        //private void CoreWindow_KeyDown(CoreWindow sender, KeyEventArgs args)

        //{
        //    if (args.VirtualKey == Windows.System.VirtualKey.Escape)

        //    {//启用ESC键退出
        //        colume_1.Width = new GridLength(0);
        //    }
        //}
    }
}
