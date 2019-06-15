using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using The_Paper.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace The_Paper.Views
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class SettingPage : Page
    {
        private ApplicationDataContainer local_systemSound = ApplicationData.Current.LocalSettings;
        public SettingPage()
        {
            this.InitializeComponent();
        }

        private async void Comment_button_Click(object sender, RoutedEventArgs e)
        {
            bool result = await SettingPageClass.SetComment();
        }

        private async void Email_button_Click(object sender, RoutedEventArgs e)
        {
            await SettingPageClass.ComposeEmail();
        }

        private void Setting_toggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            if (setting_toggleSwitch.IsOn)
            {
                ElementSoundPlayer.State = ElementSoundPlayerState.On;
                local_systemSound.Values["IsSoundOn"] = "On";
                //ElementSoundPlayer.Volume = 0.5;
            }
            else
            {
                ElementSoundPlayer.State = ElementSoundPlayerState.Off;
                local_systemSound.Values["IsSoundOn"] = "Off";
            }
        }

        private void SetIsToggleSwitchIsOn()
        {
            try
            {
                string isOn_str = local_systemSound.Values["IsSoundOn"].ToString();
                switch (isOn_str)
                {
                    case "On":
                        setting_toggleSwitch.IsOn = true;
                        break;
                    case "Off":
                        setting_toggleSwitch.IsOn = false;
                        break;
                }
            }
            catch
            {
                setting_toggleSwitch.IsOn = true;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            SetIsToggleSwitchIsOn();
        }

        private async void More_button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            bool result = await Windows.System.Launcher.LaunchUriAsync(new Uri("ms-windows-store://publisher/?name=singhwong"));
        }
    }
}
