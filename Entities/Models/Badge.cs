namespace Entities.Models
{
    public class Badge
    {
        public Guid Id { get; set; } = Guid.Empty;
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
        public string? TaskDescription { get; set; }
        public string? SubmissionInstructions { get; set; }
    }
}
