using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models
{
	public class Book
	{
		[Key]
		public int BookId { get; set; }

		[Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string Genre { get; set; } // Changed from Gerne to Genre

        [Required]
        [Range(0, 1000)]
        public int Height { get; set; }

		[Required]
        [Range (0, 100)]
		public int Thickness { get; set; }

        [Required]
        [ForeignKey("Shelf")]
        public int ShelfId { get; set; }

        public virtual Shelf Shelf { get; set; }

    }
}
