namespace labaratornaya1
{
	internal class Book
	{
		private string nazva;
		private string author;
		private string publish;
		private ushort year;
		private string udk;
		public Book(string nazva = "", string author = "", string publish = "", ushort year = 0, string udk = "")
		{
			this.nazva = nazva;
			this.author = author;
			this.publish = publish;
			this.year = year;
			this.udk = udk;
		}

		public override string ToString()
		{
			return $"{nazva}; {author}; {publish}; {year}; {udk}";
		}

		public override bool Equals(object? obj)
		{
			Book? second = obj as Book;
			if (second != null)
			{
				if (this.publish == second.publish && this.nazva == second.nazva &&
					this.udk == second.udk && this.author == second.author && this.year == second.year)
				{
					return true;
				}
			}
			return false;
		}
	}
}
