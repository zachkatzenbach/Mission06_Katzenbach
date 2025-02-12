using System.ComponentModel.DataAnnotations;

namespace Mission__6.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool? Edited { get; set; }
        public string? LentTo { get; set; }

        //Make maximum length 25 characters
        [StringLength(25)]
        public string? Notes { get; set; }
    }
}
