namespace AstroWorldZodiac.Models.Entities
{
    public class Feedback
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
