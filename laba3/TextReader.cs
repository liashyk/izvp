using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
	internal class TextReader
	{
		public string Text { get; set; } = "";
		public TextReader(string filePath)
		{
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
				if (!wordAmount.ContainsKey(word))
				{
					wordAmount.Add(word,1);
				}
				else
				{
					wordAmount[word] = wordAmount[word] + 1;
				}
			}
			return wordAmount.OrderByDescending(a =>
			{
				return a.Value;
			});
		}
	}
}
