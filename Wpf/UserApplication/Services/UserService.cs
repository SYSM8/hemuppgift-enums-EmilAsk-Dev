using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UserApplication.Models;

namespace UserApplication.Services
{
    public class UserService
    {
        private readonly string _filePath = "users.json";
        private List<User> _users;

        public UserService()
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            if (File.Exists(_filePath))
            {
                var json = File.ReadAllText(_filePath);
                _users = JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();
            }
            else
            {
                _users = new List<User>();
            }
        }

        public void AddUser(User user)
        {
            _users.Add(user);
            SaveUsers();
        }

        private void SaveUsers()
        {
            var json = JsonConvert.SerializeObject(_users, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }

        public bool ValidateUser(string username, string password)
        {
            // Implement user validation logic
            return _users.Exists(u => u.Username == username && u.Password == password);
        }
    }
}
