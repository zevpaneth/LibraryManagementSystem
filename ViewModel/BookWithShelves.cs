using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.ViewModel
{
    public class BookWithShelves
    {
        public Book? Book { get; set; }
        public int? SelectedShelfId { get; set; }
        public List<Shelf>? Shelves { get; set; }
    }
}
