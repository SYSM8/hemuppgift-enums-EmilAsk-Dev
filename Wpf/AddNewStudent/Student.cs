using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AddNewStudent
{
    class Student
    {
        // Private fields to store data.
        private string _username;
        private string _password;

        // Public properties with encapsulation and validation logic.
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _username = value;
                }
                else
                {
                    MessageBox.Show("Username cannot be empty.");
                }
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _password = value;
                }
                else
                {
                    MessageBox.Show("Password cannot be empty.");
                }
            }
        }

        // Public property for IsAdmin.
        public bool IsAdmin { get; set; }

        // Method to check if the student's username or password is empty.
        public bool IsEmpty()
        {
            return string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password);
        }
    }
}
