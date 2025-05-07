namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.DOMAIN.EntityEvents;

public class FeedbackEvent
{
    public class CreateFeedback
    {
        public Guid FeedbackId { get; set; }
        public Guid ServiceId { get; set; }
        public ICollection<string> Images { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public User User { get; set; }
        public double NewRating { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
    
    public class UpdateFeedback
    {
        public Guid FeedbackId { get; set; }
        public Guid ServiceId { get; set; }
        public ICollection<string> Images { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public double NewRating { get; set; }
        public DateTimeOffset UpdateAt { get; set; }
    }
    
    public class ViewActionFeedback
    {
        public Guid FeedbackId { get; set; }
        public Guid ServiceId { get; set; }
        public bool IsView { get; set; }
    }
    
    public class User
    {
        public Guid Id { get; set; }
        public string Avatar { get; set; }
        public string PhoneNumber { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}