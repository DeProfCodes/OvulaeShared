namespace OvulaeShared.Models.User
{
    public class UserSession
    {
        public int Id { get; set; }

        public string UserId { get; set; } // Store user's unique ID

        public string SessionToken { get; set; } // Unique token for each session

        public DateTime LoginTime { get; set; }
    }
}
