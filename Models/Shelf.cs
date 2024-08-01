using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
	public class Shelf
	{
		[Key]
		public int ShelfId { get; set; }

		[Required]
		public int Height { get; set; }

		[Required]
		public int MaxWidth { get; set; }


		public List<Book>? Books { get; set; } = new List<Book>();
	}
}
