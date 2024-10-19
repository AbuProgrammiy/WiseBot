namespace WiseBot.Domain.Entities.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public bool IsBlocked { get; set; }
        public List<Quote> quotes { get; set; }
    }
}
