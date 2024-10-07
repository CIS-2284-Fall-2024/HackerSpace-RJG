using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    /// <summary>
    /// Represents a hackerspace badge
    /// </summary>
    public class Badge
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "You must provide a title!")]
        [MinLength(3, ErrorMessage = "Must have at least 3 characters.")]
        public string? Title { get; set; }

        [Required]
        [MinLength(7)]
        public string? Description { get; set; }

        [Required]
        [MinLength(7)]
        public string? Task { get; set; }

        [Required]
        [MinLength(7)]
        public string? TurninInstructions { get; set; }

        public string? ImagePath { get; set; }
    }
}
