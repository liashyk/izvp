using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaratornaya1
{
	internal class LibraryStore
	{
		private List<Book> books;
		public LibraryStore() 
		{
			books= new List<Book>();
		}

		public void AddBook(Book book)
		{
			books.Add(book);
		}

		public void RemoveBook(Book book)
		{
			books.Remove(book);
		}

		public void Show()
		{
			foreach (Book book in books)
			{
				Console.WriteLine(book);
			}
		}
	}
}
