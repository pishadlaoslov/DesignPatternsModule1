using System;
using System.Collections.Generic;

namespace UserManagementSystem
{
   
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        public User(string name, string email, string role)
        {
            Name = name;
            Email = email;
            Role = role;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Email: {Email}, Role: {Role}";
        }
    }

   
    public class UserManager
    {
        private List<User> users = new List<User>();

        public void AddUser(User user)
        {
            if (user == null) return;

            if (!UserExists(user.Email))
            {
                users.Add(user);
                Console.WriteLine("User added.");
            }
            else
            {
                Console.WriteLine("User with this email already exists.");
            }
        }

        public void RemoveUser(string email)
        {
            var user = FindUserByEmail(email);
            if (user != null)
            {
                users.Remove(user);
                Console.WriteLine("User removed.");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        public void UpdateUser(string email, string newName, string newRole)
        {
            var user = FindUserByEmail(email);
            if (user != null)
            {
                user.Name = newName;
                user.Role = newRole;
                Console.WriteLine("User updated.");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        public void ListUsers()
        {
            if (users.Count == 0)
            {
                Console.WriteLine("No users found.");
                return;
            }

            Console.WriteLine("Users:");
            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
        }

        
        private User? FindUserByEmail(string email)
        {
            return users.Find(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }

        private bool UserExists(string email)
        {
            return FindUserByEmail(email) != null;
        }
    }

    
    class Program
    {
        static void Main()
        {
            var userManager = new UserManager();

            var user1 = new User("Alice", "alice@example.com", "Admin");
            var user2 = new User("Bob", "bob@example.com", "User");

            userManager.AddUser(user1);
            userManager.AddUser(user2);

            userManager.ListUsers();

            userManager.UpdateUser("bob@example.com", "Robert", "Admin");

            userManager.RemoveUser("alice@example.com");

            userManager.ListUsers();
        }
    }
}
