using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace AddNewStudent
{
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        List<string> roles = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = students;
            
        }

        // Adding a new student
        private void Add_User(object sender, RoutedEventArgs e)
        {
            var newStudent = new Student
            {
                Username = Username.Text,
                Password = Password.Password,
                IsAdmin = IsAdmin.IsChecked ?? false
            };

            if (!newStudent.IsEmpty())
            {
                students.Add(newStudent);
                RefreshDataGrid();
                ClearUserInputs();
            }
            else
            {
                MessageBox.Show("Please enter valid student details.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Roles(object sender, RoutedEventArgs e)
        {
            // Navigate to the RolesPage
            MainFrame.Navigate(new RolesPage());
        }

        private void Hej(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hej");
        }

        private void RefreshDataGrid()
        {
            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = students;
        }

        private void ClearUserInputs()
        {
            Username.Text = string.Empty;
            Password.Password = string.Empty;
            IsAdmin.IsChecked = false;
        }
    }
}
