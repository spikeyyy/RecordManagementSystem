using System.Collections.Generic;
namespace RecordManagementSystem.Model
{

    public class UserModel
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? SelectedRole { get; set; } // Change SelectedRole to string
        public List<string> Roles { get; set; }

        public UserModel()
        {
            Roles = new List<string> { "Admin", "User" };
        }
    }

}

