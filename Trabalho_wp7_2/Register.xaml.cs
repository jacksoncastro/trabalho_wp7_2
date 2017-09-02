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

    public sealed partial class Register : Page
    {
        public Register()
        {
            this.InitializeComponent();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            int lastId = 0;
            if (LoginManager.Users.Count > 0)
            {
                lastId = LoginManager.Users.Max(maxUser => maxUser.Id);
            }

            User user = new User(++lastId, name.Text, login.Text, password.Password);
            LoginManager.Users.Add(user);

            this.Frame.Navigate(typeof(Login));
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Login));
        }
    }
}
