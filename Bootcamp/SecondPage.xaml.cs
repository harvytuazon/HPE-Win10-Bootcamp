using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Bootcamp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SecondPage : Page
    {
        public SecondPage()
        {
            this.InitializeComponent();

            var menu = new ObservableCollection<Menu>();
            menu.Add(new Menu() { Title = "Home", Icon = "\xE10F", Page = typeof(LoginPage), Checked = false });
            menu.Add(new Menu() { Title = "Summary", Icon = "\xE125", Page = typeof(SecondPage), Checked = false });
            menu.Add(new Menu() { Title = "Add", Icon = "\xE1E2", Page = typeof(SecondPage), Checked = true });
            menu.Add(new Menu() { Title = "Edit", Icon = "\xE104", Page = typeof(MainPage), Checked = false });
            menu.Add(new Menu() { Title = "Delete", Icon = "\xE1E0", Page = typeof(MainPage), Checked = false });
            menu.Add(new Menu() { Title = "Settings", Icon = "\xE115", Page = typeof(MainPage), Checked = false });

            MenuList.ItemsSource = menu;

            var user = new Users()
            {
                FirstName = "Joyce",
                LastName = "Nacorda",
                Email = "joyce.nacorda@hpe.com"
            };

            UserData.Content = user;

            SampleText.Text = "The information transmitted is intended solely for the individual or entity to which it is addressed and may contain Hewlett Packard Company confidential and/or privileged material. Any review, retransmission, dissemination or other use of or taking action in reliance upon this information by persons or entities other than the intended recipient is prohibited. If you have received this email in error please contact the sender and delete the material from any computer.";
        }

        private void MenuClick(object sender, RoutedEventArgs e)
        {
            SplitMenu.IsPaneOpen = !SplitMenu.IsPaneOpen;
        }

        private void MenuItemClick(object sender, RoutedEventArgs e)
        {
            var button = sender as ToggleButton;
            var data = button.Tag as Menu;
            
            this.Frame.Navigate(data.Page);
        }
    }
}
