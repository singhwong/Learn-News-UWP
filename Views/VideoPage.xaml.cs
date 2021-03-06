﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using The_Paper.Models;
using The_Paper.ViewModels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace The_Paper.Views
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class VideoPage : Page
    {
        private int index;
        VideoPageVM videoPageVM;
        public VideoPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            videoPageVM = new VideoPageVM(e.Parameter as Channel);
            this.DataContext = videoPageVM;
        }

        private void playButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            videoPageVM.PlayTop();
            mediaElement.Visibility = Visibility.Visible;
        }

        private async void TabView_TabSwitch(object sender, EventArgs e)
        {
            index = (e as TabSwitchEventArgs).tabIndex;
            videoStatus_textblock.Visibility = Visibility.Collapsed;//优化切换视频类别时，内容加载过程中，
            mediaElement.Visibility = Visibility.Collapsed;
            mediaElement.Stop();
            #region 优化点击顶部标题烂选项，右边会出现 NewsDetail Page bug,尚不知为何会出现这种情况
            //colume_2.Width = new GridLength(0);
            back_button.Visibility = Visibility.Collapsed;
            #endregion
            if (index == 0)
            {
                //videoRow_1.Height = new GridLength(1, GridUnitType.Star);
            }
            else
            {
                //videoRow_1.Height = new GridLength(1, GridUnitType.Auto);
            }
            VideoDetail_grid.Visibility = Visibility.Collapsed;
            //右上角显示videoStatus_textblock文本bug
            await videoPageVM.LoadColumn(index);
            videoStatus_textblock.Visibility = Visibility.Visible;         
        }

        private void mediaElement_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            //EnterAnim.Begin();
            //EnterAnim.Completed += (sender1, e1) => VideoInfo.Visibility = Visibility.Visible;
        }

        private void mediaElement_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            //ExitAnim.Begin();
            //EnterAnim.Completed += (sender1, e1) => VideoInfo.Visibility = Visibility.Collapsed;
        }

        private void ScrollViewer_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {
            if ((sender as ScrollViewer).VerticalOffset + (sender as ScrollViewer).ViewportHeight
                == (sender as ScrollViewer).ExtentHeight)
                videoPageVM.LoadMore();
        }

        private void Back_button_Click(object sender, RoutedEventArgs e)
        {
            back_button.Visibility = Visibility.Collapsed;
            mediaElement.Visibility = Visibility.Collapsed;
            mediaElement.Pause();
            VideoDetail_grid.Visibility = Visibility.Collapsed;
            if (index == 0)
            {
                //videoRow_1.Height = new GridLength(1, GridUnitType.Star);
            }
            else
            {
                //videoRow_1.Height = new GridLength(1, GridUnitType.Auto);
            }
        }

        private void VideoCards_ItemClick(object sender, ItemClickEventArgs e)
        {
            mediaElement.AutoPlay = true;
            videoPageVM.Play((Video)(e.ClickedItem));
            VideoDetail.Navigate(typeof(VideoDetailPage), ((Video)(e.ClickedItem)).uri);
            back_button.Visibility = Visibility.Visible;
            //colume_2.Width = new GridLength(1,GridUnitType.Auto);
            //videoRow_1.Height = new GridLength(1, GridUnitType.Star);
            mediaElement.Visibility = Visibility.Visible;
            VideoDetail_grid.Visibility = Visibility.Visible;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //ad_stackPanel.Visibility = Visibility.Visible;
            mediaElement.AutoPlay = false;
        }

        private void Close_button_Click(object sender, RoutedEventArgs e)
        {
            VideoDetail_grid.Visibility = Visibility.Collapsed;           
        }

        private void CloseAd_button_Click(object sender, RoutedEventArgs e)
        {
            ad_stackPanel.Visibility = Visibility.Collapsed;
        }
    }
}
