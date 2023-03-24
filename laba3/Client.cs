using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace laba3
{
	internal class Client
	{
		private string name;
		private string password;
		private string email;
		private string phone;

		public Client(string name="", string password = "", string email = "") 
		{
			this.name = name;
			this.password = password;
			this.email = email;
		}
		public string Name 
		{
			get
			{
				return name;
			}
			set
			{
				if (Regex.IsMatch(value, "[A-Zа-я][a-zа-я]+"))
				{
					name= value;
				}
			} 
		}

		public string Password
		{
			get
			{
				return password;
			}
			set
			{
				if (Regex.IsMatch(value, "\\w+"))
				{
					name = value;
				}
			}
		}

		public string Phone
		{
			get
			{
				return phone;
			}
			set
			{
				if (Regex.IsMatch(value, "(\\d)+(.*\\d)+(.* )*(.*-)*"))
				{
					phone = value;
				}
			}
		}
		public string Email
		{
			get
			{
				return email;
			}
			set
			{
				if (Regex.IsMatch(value, "\\w+@\\w+.\\w+"))
				{
					email = value;
				}
			}
		}

	}
}
