using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
	//TO DO
	internal class TextReader
	{
		public string Text { get; set; } = "";
		private string filePath = "";
		public TextReader(string filePath)
		{
			this.filePath = filePath;
			using (StreamReader sr = new StreamReader(filePath))
			{
				Text = sr.ReadToEnd();
			}
		}

		public IEnumerable<string> GetWords()
		{
			return Text.Split(" ");
		}

		public IEnumerable<KeyValuePair<string,int>> GetWordAmountDictionary()
		{
			Dictionary<string, int> wordAmount = new Dictionary<string, int>();
			IEnumerable<string> words = GetWords();
			foreach (string word in words)
			{
				if(word.Length>0)
				{
					if (!wordAmount.ContainsKey(word))
					{
						wordAmount.Add(word, 1);
					}
					else
					{
						wordAmount[word] = wordAmount[word] + 1;
					}
				}
			}
			return wordAmount.OrderByDescending(a =>
			{
				return a.Value;
			});
		}

		public string GetSimpleText()
		{
			string result = "";
			using (StreamReader sr = new StreamReader(filePath))
			{
				while(!sr.EndOfStream)
				{
					string buffer = sr.ReadLine();
					if(buffer== "Sophie" || buffer == "Neil" )
					{
						result += buffer+": ";
					}
					else
					{
						result += buffer+ "\n";
					}
				}
			}
			//result = result.Remove(0, 1);
			return result;
		}
	}
}
