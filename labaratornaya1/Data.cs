using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labaratornaya1
{
	internal class Data
	{
		private byte day;
		private byte month;
		private ushort year;

		public Data(byte day=0, byte month = 0, ushort year=0)
		{
			this.day = day;
			this.month = month;
			this.year = year;
		}

		public override string ToString()
		{
			return $"{day}:{month}:{year}";
		}
	}
}
