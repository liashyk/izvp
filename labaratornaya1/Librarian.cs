namespace labaratornaya1
{
	internal class Librarian : Human
	{
		private LibraryStore store;
		public Librarian(string name, Data data, LibraryStore libraryStore):base(name,data)
		{
			store = libraryStore;
		}
		public void AddBook(Book book)
		{
			store.AddBook(book);
		}
		public void RemoveBook(Book book)
		{
			store.RemoveBook(book);
		}
		public Order CreateOrder(IEnumerable<Book> books, Student student)
		{
			Data currentDate = new Data(1, 1, 2023);
			Data expirationDate = new Data(1, 3, 2023);
			Order order = new Order(currentDate, expirationDate, student, books);

			return order;
		}

		public Order CreateOrder(Student student)
		{
			return CreateOrder(new List<Book>(),student);
		}
	}
}
