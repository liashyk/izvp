using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaratornaya1
{
	internal class Order
	{
		private Data orderDate;
		private Data expirationDate;
		private List<Book> books;

		public Order(Data orderDate, Data expirationDate)
		{
			this.orderDate = orderDate;
			this.expirationDate = expirationDate;
			books= new List<Book>();
		}

		public Order(Data orderDate, Data expirationDate, IEnumerable<Book> books) 
		{
			this.orderDate = orderDate;
			this.expirationDate = expirationDate;
			this.books = new List<Book>();
			foreach(Book book in books)
			{
				this.books.Add(book);
			}
		}


	}
}
