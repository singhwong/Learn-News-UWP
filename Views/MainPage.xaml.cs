using System.Diagnostics;
using The_Paper.Data;
using The_Paper.ViewModels;
using The_Paper.Views;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace The_Paper
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private MainPageVM mainPageVM;
        public MainPage()
        {
            this.InitializeComponent();
            SetTitleBarColor();
        }

        private void SetTitleBarColor()
        {
            var view = ApplicationView.GetForCurrentView();
            view.TitleBar.BackgroundColor = Colors.Black;
            view.TitleBar.ForegroundColor = Colors.White;
            view.TitleBar.ButtonBackgroundColor = Colors.Black;
            view.TitleBar.ButtonForegroundColor = Colors.White;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            mainPageVM = new MainPageVM();
            this.DataContext = mainPageVM;
    }

        private void Ham_Click(object sender, RoutedEventArgs e)
        {
            splitView.IsPaneOpen = !splitView.IsPaneOpen;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = (sender as ListView).SelectedIndex;
            switch(index)
            {
                case 0: case 2: case 3: case 4: case 5:
                case 6:
                    mainFrame.Navigate(typeof(NewsPage), ChannelsData.Channels[index]);
                    break;
                case 1:
                    mainFrame.Navigate(typeof(VideoPage), ChannelsData.Channels[index]);
                    break;
            }
            
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
           
            mainFrame.Navigate(typeof(NewsPage), ChannelsData.Channels[0]);
        }
    }
}
