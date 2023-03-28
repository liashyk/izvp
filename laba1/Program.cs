using System.Linq;

namespace laba1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//NumericalMetods.Table(0, 1, 0.1, a => a * a);
			//Console.WriteLine(NumericalMetods.SimpsonIntegral(0, Math.PI, 100, a => Math.Sin(a)));
			List<int> list = new List<int>() { 1,2,3};
			Console.WriteLine(list.Agregat(a=>a,(b1,b2)=>b1+b2));
			//var newList = Query.Range(3,10);
			//foreach (var item in newList)
			//{
			//	Console.WriteLine(item);
			//}
		}
	}
}