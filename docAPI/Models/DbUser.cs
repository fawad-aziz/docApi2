namespace docAPI.Models
{
    public class DbUser
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AccessLevelID { get; set; }
        public string Username { get; set; }
    }
}