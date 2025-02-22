using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission__6.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        [Required(ErrorMessage = "Please enter a valid movie title.")]
        public string Title { get; set; }

        //Ensures there is input between 1888 and present day
        [Range(1888, 2025, ErrorMessage = "Please enter a year between 1888 and 2025.")]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }

        [Required(ErrorMessage = "Please enter whether or not the movie was edited.")]
        public int Edited { get; set; }
        public string? LentTo { get; set; }

        [Required(ErrorMessage = "Please enter whether or not the movie was copied to plex.")]
        public int CopiedToPlex { get; set; }

        //Make maximum length 25 characters
        [StringLength(25)]
        public string? Notes { get; set; }
    }
}
