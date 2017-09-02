using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Trabalho_wp7_2
{
    public sealed partial class MainPage : Page
    {
        User user;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }


        private void Detalhes_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(Detail));
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            this.user = e.Parameter as User;

            LoginManager.currentUser = user;

            wellcome.Text = String.Format("Bem vindo {0}", user.Name);
        }

        private void listUsers_Click(object sender, RoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(ListUsers));
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Login));
        }
    }
}
