using TaskManager.Common.Models;

namespace TaskManager.Api.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LastLogDate { get; set; }
        public byte[] Photo { get; set; }
        public List<Project> Projects { get; set; } = new List<Project>();
        public List<Desk> Desks { get; set; } = new List<Desk>();
        public List<Task> Tasks { get; set; } = new List<Task>();
        public UserStatus Status { get; set; }
        public User()
        {
            
        }
        public User(UserModel userModel)
        {
            Id = userModel.Id;
            FirstName = userModel.FirstName;
            LastName = userModel.LastName;
            Email = userModel.Email;
            Password = userModel.Password;
            Status = userModel.Status;
            Phone = userModel.Phone;
            Photo = userModel.Photo;
            RegistrationDate = userModel.RegistrationDate;
        }
        public User(string fname, string lname, string email, string password, 
            UserStatus status = UserStatus.User, string phone = null, byte[] photo = null)
        {
            FirstName = fname;
            LastName = lname;
            Email = email;
            Password = password;
            Status = status;
            Phone = phone;
            Photo = photo;
            RegistrationDate = DateTime.Now;
        }
        public UserModel ToDto()
        {
            return new UserModel
            {
                Id = this.Id,
                FirstName = this.FirstName,
                LastName = this.LastName,
                Email = this.Email,
                Password = this.Password,
                Status = this.Status,
                Phone = this.Phone,
                Photo = this.Photo,
                RegistrationDate = this.RegistrationDate
            };
        }
    }
}
