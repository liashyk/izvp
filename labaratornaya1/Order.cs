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
		private Student student;

		public Order(Data orderDate, Data expirationDate, Student student)
		{
			this.orderDate = orderDate;
			this.expirationDate = expirationDate;
			books = new List<Book>();
			this.student = student;
		}

		public Order(Data orderDate, Data expirationDate, Student student,IEnumerable<Book> books) 
		{
			this.orderDate = orderDate;
			this.expirationDate = expirationDate;
			this.books = new List<Book>();
			this.student = student;
			foreach (Book book in books)
			{
				this.books.Add(book);
			}
		}

		public override string ToString()
		{
			var result = "";
			result+=" "+orderDate+"\n";
			result += " " + expirationDate + "\n";
			foreach(Book book in books)
			{
				result += " " + book + "\n";
			}
			return result;
		}


	}
}
