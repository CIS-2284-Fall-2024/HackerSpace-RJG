namespace Entities.Models
{
    /// <summary>
    /// Represents a hackerspace badge
    /// </summary>
    public class Badge
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Task { get; set; }
        public string? TurninInstructions { get; set; }
        public string? ImagePath { get; set; }
    }
}
