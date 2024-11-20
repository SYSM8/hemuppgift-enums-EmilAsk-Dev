using System.Windows;

namespace AddNewStudent
{
    class Student
    {
        private string _username;
        private string _password;

        public string Username
        {
            get { return _username; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _username = value;
                else
                    MessageBox.Show("Username cannot be empty.");
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _password = value;
                else
                    MessageBox.Show("Password cannot be empty.");
            }
        }

        public bool IsAdmin { get; set; }

        public bool IsEmpty()
        {
            return string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password);
        }
    }
}
