
namespace LibrarryTP.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string? SecondName { get; set; }

        public string Password { get; set; }

        public DateTime? DateBirth { get; set; }

        public int? Role { get; set; }
    }
}
