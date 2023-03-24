using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaratornaya1
{
	internal class Librarian:Human
	{
		private LibraryStore store;
		public Librarian(LibraryStore libraryStore) 
		{
			store= libraryStore;
		}
		public void AddBook(Book book)
		{
			store.AddBook(book);
		}
		public void RemoveBook(Book book)
		{
			store.RemoveBook(book);
		}
		public Order CreateOrder(IEnumerable<Book> books)
		{
			Data currentDate = new Data(1, 1, 2023);
			Data expirationDate = new Data(1, 3, 2023);
			Order order = new Order(currentDate, expirationDate,books);

			return order;
		}

		public Order CreateOrder()
		{
			return CreateOrder(new List<Book>());
		}
	}
}
