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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace kolmasProjekt
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int loginCount = 0;
        bool canLogin = true;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            string name = "stupidcats";
            string pass = "password";
            
            if(username.Text == name && password.Password == pass && canLogin)
            {
                feedbackMsg.Text = "Login successful!";
                this.Frame.Navigate(typeof(profilepage), name);
            }
            else
            {
                if (loginCount == 3)
                {
                    canLogin = false;
                    feedbackMsg.Text = "You cannot login no more!";
                }
                else
                {
                    loginCount++;
                    feedbackMsg.Text = "Wrong username or password!";
                }
              
            }
        }
    }
}
