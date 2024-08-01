using System.ComponentModel.DataAnnotations;


namespace LibraryManagementSystem.Models
{
	public class Section
	{
		[Key]
		public int SectionId { get; set; }

		[Required]
		public string name { get; set; }

		public List<Shelf> Shelves { get; set; } = new List<Shelf>();

        // Foreign key to Library
        public int LibraryId { get; set; }
        public Library Library { get; set; }

    }
}
