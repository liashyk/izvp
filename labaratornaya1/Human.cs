using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaratornaya1
{
	abstract class Human
	{
		protected Data? data;
		protected string name;

		public Human() {
			this.name = "";
			this.data = new Data();
		}

		public Human(string name, Data data)
		{
			this.name = name;
			this.data = data;
		}

		void Show()
		{
			Console.WriteLine(name+" "+data);
		}

	}
}
