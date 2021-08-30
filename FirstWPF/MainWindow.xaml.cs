using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FirstWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MockUsers.addUsers();
        }

        private void SignUpBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Du är signerad!!");
        }

        private void NavGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Vill du avsluta applikationen?", "Säker?",MessageBoxButton.YesNoCancel);
            
            if(result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }            
        }

        private void SignInBtn_Click(object sender, RoutedEventArgs e)
        {
            bool found = false;

            foreach (var user in MockUsers.users)
            {
                if(EmailBox.Text == user.Email && PassWordBox.Password == user.PassWord)
                { 
                    found = true;
                }
            }

            string message = found == true ? "Du har loggat in" : "Uppgifterna stämmer inte";
            MessageBox.Show(message);

            EmailBox.Clear();
            PassWordBox.Clear();
        }

    }
}
