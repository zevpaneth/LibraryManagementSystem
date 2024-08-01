using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
	public class Library
	{
		[Key]
		public int LibraryId { get; set; }

		public List<Section> Sections {  get; set; } = new List<Section>();


	}
}
