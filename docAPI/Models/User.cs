namespace docAPI.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AccessLevel AccessLevel { get; set; }
        public string Username { get; set; }
    }

    public enum AccessLevel
    {
        User,
        Admin,
        Configuration,
        Test
    }
}