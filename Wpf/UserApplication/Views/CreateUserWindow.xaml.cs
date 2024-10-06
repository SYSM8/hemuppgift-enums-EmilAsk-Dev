using System.Windows;
using MahApps.Metro.Controls;
using UserApplication.Models;
using UserApplication.Services;

namespace UserApplication.Views
{
    public partial class CreateUserWindow : MetroWindow
    {
        private readonly UserService _userService;

        public CreateUserWindow(UserService userService)
        {
            InitializeComponent();  // Ensure this is included
            _userService = userService;
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            var username = NewUsernameTextBox.Text;
            var password = NewPasswordTextBox.Password;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter a valid username and password.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var newUser = new User { Username = username, Password = password };
            _userService.AddUser(newUser);

            MessageBox.Show("User created successfully!");
            this.Close();  // This should work if everything is set up correctly
        }
    }
}
