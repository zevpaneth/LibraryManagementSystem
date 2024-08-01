using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;


namespace LibraryManagementSystem.DAL
{
	public class LibraryDbContext : DbContext
	{
		public DbSet<Library> Libraries { get; set; }
		public DbSet<Section> Sections { get; set; }
		public DbSet<Shelf> Shelves { get; set; }
		public DbSet<Book> Books { get; set; }

		public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
		: base(options)
		{
			// לוודא שהבסיס נתונים והטבלאות קיימות, אם לא תייצר את כולם ריקות
			Console.WriteLine("Database Exists: " + Database.EnsureCreated());

			// במידה ואין נתונים בטבלת נעליים, נזין כמה נתונים כדי שנוכל להתחיל
			if (Libraries?.Count() == 0)
			{
				Seed();
			}
		}

		public void Seed()
		{
			Library library = new Library();
			Libraries.Add(library);

            Shelf shelf1 = new Shelf { Height = 30, MaxWidth = 100 };
			Shelf shelf2 = new Shelf { Height = 40, MaxWidth = 120 };
			Shelf shelf3 = new Shelf { Height = 50, MaxWidth = 150 };
			Shelf shelf4 = new Shelf { Height = 60, MaxWidth = 200 };


			Section section1 = new Section { name = "Tora" };
			section1.Shelves.Add(shelf1);
			section1.Shelves.Add(shelf2);
			section1.Shelves.Add(shelf3);
			section1.Shelves.Add(shelf4);
			Section section2 = new Section { name = "Halacha" };
			section2.Shelves.Add(shelf1);
			section2.Shelves.Add(shelf2);
			section2.Shelves.Add(shelf3);
			section2.Shelves.Add(shelf4);
			Section section3 = new Section { name = "Chassidus" };
			section3.Shelves.Add(shelf1);
			section3.Shelves.Add(shelf2);
			section3.Shelves.Add(shelf3);
			section3.Shelves.Add(shelf4);
			Section section4 = new Section { name = "Mussar" };
			section4.Shelves.Add(shelf1);
			section4.Shelves.Add(shelf2);
			section4.Shelves.Add(shelf3);
			section4.Shelves.Add(shelf4);

			library.Sections.Add(section1);
			library.Sections.Add(section2);
			library.Sections.Add(section3);
			library.Sections.Add(section4);

			SaveChanges();
		}



    }
}

