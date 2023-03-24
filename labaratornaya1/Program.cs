namespace labaratornaya1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			LibraryStore libraryStore = new LibraryStore();
			Student student = new Student("Vasya", new Data(1, 1, 2004), 4);
			Librarian librarian = new Librarian(libraryStore);

			Book dorianGrey = new Book("Dorian Grey", "Oscar Wild", "OklaOpla", 2020, "qwe");
			Book romeAndJulieta = new Book("Romeo and Juliets", "William Shakespeare", "duka luka", 2010, "poi");

			librarian.AddBook(dorianGrey);
			librarian.AddBook(romeAndJulieta);

			List<Book> books = new List<Book>();
			books.Add(romeAndJulieta) ;
			books.Add(dorianGrey);
			student.AddOrder(librarian.CreateOrder(books));
		}
	}
}