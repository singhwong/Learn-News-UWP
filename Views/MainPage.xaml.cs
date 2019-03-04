using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using The_Paper.Data;
using The_Paper.Models;
using The_Paper.ViewModels;
using The_Paper.Views;
using Windows.Storage;
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
        private ApplicationDataContainer local_systemSound = ApplicationData.Current.LocalSettings;
        private ObservableCollection<SettingItem> setting_list;
        private MainPageVM mainPageVM;
        public MainPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
            SetTitleBarColor();
            setting_list = new ObservableCollection<SettingItem>();
            SetIsElementSoundPlayerIsOn();
            setting_list.Add(new SettingItem("设置"));
            mainFrame.Navigate(typeof(NewsPage), ChannelsData.Channels[0]);
        }

        private void SetTitleBarColor()
        {
            var view = ApplicationView.GetForCurrentView();
            view.TitleBar.BackgroundColor = Colors.WhiteSmoke;
            view.TitleBar.ForegroundColor = Colors.Black;
            view.TitleBar.InactiveBackgroundColor = Colors.WhiteSmoke;
            view.TitleBar.InactiveForegroundColor = Colors.Black;
            view.TitleBar.ButtonBackgroundColor = Colors.WhiteSmoke;
            view.TitleBar.ButtonForegroundColor = Colors.Black;
            view.TitleBar.ButtonInactiveBackgroundColor = Colors.WhiteSmoke;
            view.TitleBar.ButtonInactiveForegroundColor = Colors.Black;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            mainPageVM = new MainPageVM();
            this.DataContext = mainPageVM;
    }

        private void Ham_Click(object sender, RoutedEventArgs e)
        {
            splitView.IsPaneOpen =! splitView.IsPaneOpen;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {           
            
        }

        private void Menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            setting_listView.SelectedItem = null;
            int index = (sender as ListView).SelectedIndex;
            switch (index)
            {
                case 0:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    mainFrame.Navigate(typeof(NewsPage), ChannelsData.Channels[index]);
                    break;
                case 1:
                    mainFrame.Navigate(typeof(VideoPage), ChannelsData.Channels[index]);
                    break;
            }
        }

        private void Setting_listView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Menu.SelectedItem = null;
            Frame.Navigate(typeof(SettingPage));
        }

        private void SetIsElementSoundPlayerIsOn()
        {
            try
            {
                string isOn_str = local_systemSound.Values["IsSoundOn"].ToString();
                switch (isOn_str)
                {
                    case "On":
                        ElementSoundPlayer.State = ElementSoundPlayerState.On;
                        break;
                    case "Off":
                        ElementSoundPlayer.State = ElementSoundPlayerState.Off;
                        break;
                }
            }
            catch
            {
                ElementSoundPlayer.State = ElementSoundPlayerState.On;
            }
            ElementSoundPlayer.Volume = 0.1;
        }
    }
}
