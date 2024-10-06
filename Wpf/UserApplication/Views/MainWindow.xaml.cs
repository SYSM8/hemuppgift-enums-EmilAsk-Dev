using System.Windows;
using UserApplication.Models;
using UserApplication.Services;
using MahApps.Metro.Controls; // Ensure this is included

namespace UserApplication.Views
{
    public partial class MainWindow : MetroWindow // Ensure this matches the XAML
    {
        private readonly UserService _userService;

        public MainWindow()
        {
            InitializeComponent();
            _userService = new UserService(); // Initialize the UserService
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var username = UsernameTextBox.Text;
            var password = PasswordTextBox.Password;

            if (_userService.ValidateUser(username, password))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                // TODO: Navigate to the main application page after successful login
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ShowCreateUserFormButton_Click(object sender, RoutedEventArgs e)
        {
            // Show the create user form and hide the login form
            LoginPanel.Visibility = Visibility.Collapsed;
            CreateUserPanel.Visibility = Visibility.Visible;
        }

        private void ShowLoginFormButton_Click(object sender, RoutedEventArgs e)
        {
            // Show the login form and hide the create user form
            CreateUserPanel.Visibility = Visibility.Collapsed;
            LoginPanel.Visibility = Visibility.Visible;
        }

        private void CreateUserButton_Click(object sender, RoutedEventArgs e)
        {
            var newUsername = NewUsernameTextBox.Text;
            var newPassword = NewPasswordTextBox.Password;

            if (string.IsNullOrWhiteSpace(newUsername) || string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Please enter a valid username and password.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var newUser = new User { Username = newUsername, Password = newPassword };
            _userService.AddUser(newUser);

            MessageBox.Show("User created successfully!");
            NewUsernameTextBox.Clear(); // Clear the input fields after creation
            NewPasswordTextBox.Clear();
        }
    }
}
