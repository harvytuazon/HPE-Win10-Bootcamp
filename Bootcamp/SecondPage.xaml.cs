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
            menu.Add(new Menu() { Title = "Add" });
            menu.Add(new Menu() { Title = "Edit" });
            menu.Add(new Menu() { Title = "Delete" });
            menu.Add(new Menu() { Title = "Add" });
            menu.Add(new Menu() { Title = "Edit" });
            menu.Add(new Menu() { Title = "Delete" });
            menu.Add(new Menu() { Title = "Add" });
            menu.Add(new Menu() { Title = "Edit" });
            menu.Add(new Menu() { Title = "Delete" });
            menu.Add(new Menu() { Title = "Add" });
            menu.Add(new Menu() { Title = "Edit" });
            menu.Add(new Menu() { Title = "Delete" });
            menu.Add(new Menu() { Title = "Add" });
            menu.Add(new Menu() { Title = "Edit" });

            MenuList.ItemsSource = menu;

            var user = new Users()
            {
                FirstName = "Joyce",
                LastName = "Nacorda",
                Email = "joyce.nacorda@hpe.com"
            };

            UserData.Content = user;

            SampleText.Text = "Hello World";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SplitMenu.IsPaneOpen = !SplitMenu.IsPaneOpen;
        }
    }
}
