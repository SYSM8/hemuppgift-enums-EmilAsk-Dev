using System.Windows;
using System.Windows.Controls;

namespace AddNewStudent
{
    public partial class RolesPage : Page
    {
        public RolesPage()
        {
            InitializeComponent();
            // Initialize with some roles for demonstration
            RolesListBox.Items.Add("Admin");
            RolesListBox.Items.Add("User");
            RolesListBox.Items.Add("Guest");

            // Set the placeholder text
            NewRoleTextBox.Text = "Enter new role";
            NewRoleTextBox.Foreground = System.Windows.Media.Brushes.Gray;
        }

        private void AddRole_Click(object sender, RoutedEventArgs e)
        {
            string newRole = NewRoleTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(newRole) && newRole != "Enter new role")
            {
                // Add the new role to the ListBox
                RolesListBox.Items.Add(newRole);
                NewRoleTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Role cannot be empty.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void RemoveRole_Click(object sender, RoutedEventArgs e)
        {
            // Remove the selected role from the ListBox
            if (RolesListBox.SelectedItem != null)
            {
                RolesListBox.Items.Remove(RolesListBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a role to remove.", "Selection Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void NewRoleTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (NewRoleTextBox.Text == "Enter new role")
            {
                NewRoleTextBox.Text = string.Empty;
                NewRoleTextBox.Foreground = System.Windows.Media.Brushes.Black; // Change text color to black
            }
        }

        private void NewRoleTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NewRoleTextBox.Text))
            {
                NewRoleTextBox.Text = "Enter new role";
                NewRoleTextBox.Foreground = System.Windows.Media.Brushes.Gray; // Change text color to gray
            }
        }
    }
}
