namespace laba3
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//1)
			TextReader textReader = new TextReader("C:/Users/ilya9/source/repos/izvp/laba3/EnglishDialog.txt");
			//var wordAmount = textReader.GetWordAmountDictionary();
			//foreach (var word in wordAmount)
			//{
			//	Console.WriteLine(word.Key + " : " + word.Value);
			//}
			Console.WriteLine(textReader.GetSimpleText());

			//2)
			//Client client = new Client();
			//client.Email = "ilyaasd.com";
			//Console.WriteLine(client.Email);
		}
	}
}