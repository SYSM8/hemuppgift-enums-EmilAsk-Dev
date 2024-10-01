using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AddNewStudent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Student> students = new List<Student>();

        public MainWindow()
        {
            InitializeComponent();

            // Optional: Sample data to test the DataGrid binding
            //students.Add(new Student { Username = "Emil", Password = "1234", IsAdmin = true });
            //students.Add(new Student { Username = "Bob", Password = "1234", IsAdmin = false });
            //students.Add(new Student { Username = "Charlie", Password = "1234", IsAdmin = false });

            // Bind the DataGrid to the students list
            dataGrid.ItemsSource = students;
        }

        //adding a new student
        private void Add_User(object sender, RoutedEventArgs e)
        {
            // Create a new Student object
            var newStudent = new Student
            {
                Username = Username.Text,
                Password = Password.Password,
                IsAdmin = IsAdmin.IsChecked ?? false
            };


            students.Add(newStudent);


            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = students;


            Username.Text = string.Empty;
            Password.Password = string.Empty;
            IsAdmin.IsChecked = false;
        }

    }
}