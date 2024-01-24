//using System;
//using System.Collections.Generic;
//using System.Linq;


//namespace LinqTutorial
//{
//	class Program
//	{
//static void Main(string[] args)
//{
//	var wordsNoUppercase = new string[]
//		{
//			"quick", "brown", "fox"
//		};
//	Console.WriteLine(IsAnyWordUpperCase(wordsNoUppercase));
//	var wordsWithUppercase = new string[]
//		{
//			"quick", "brown", "FOX"
//		};

//	Console.WriteLine(IsAnyWordUpperCase(wordsWithUppercase));

//	Console.ReadKey();
//}

//public static bool IsAnyWordUpperCase(IEnumerable<string> words>)
//{
//	foreach(var word in words)
//	{

//	}
//}

//		public static bool IsAnyWordUpperCase_Linq(IEnumerable<string> words)
//		{
//			return words.Any(word => word.All(letter => char.IsUpper(letter)));

//		}

//			public static bool IsAnyWordUpperCase(IEnumerable<string> words)
//		{
//			foreach (var word in words)
//			{
//				bool areAllUpperCase = true;
//				foreach (var letter in word)
//				{
//					if (char.IsLower(letter))
//					{
//						areAllUpperCase = false;
//					}
//				}

//				if (areAllUpperCase)
//				{
//					return true;
//				}
//			}

//			return false;
//		}
//	}
//}

//using System.Net;

//var words = new List<string> { "a", "bb", "ccc", "dddd" };
//var wordsLongerThan2Letters = words.Where(word => word.Length > 2);

//var numbers = new int[] { 1, 2, 3, 4, 5, 6 };
//var oddNumbers = numbers.Where(number => number % 2 == 1);

//Console.ReadKey();

//namespace LinqTutorial
//{

//	class Program
//	{
//		static void Main(string[] args)
//		{
//			var numbers = new List<int> { 5, 3, 7, 1, 2, 4 };
//			var numbersWith10 = numbers.Append(10);

//			//Console.WriteLine("Numbers: " + string.Join(", ", numbers));
//			//Console.WriteLine("Numbers with 10: " + string.Join(", ", numbersWith10));

//			//var oddNumbers = numbers.Where(number => number % 2 == 1);
//			var orderedOddNumbers = numbers.Where(number => number % 2 == 1)
//				.OrderBy(number => number);
//			Console.WriteLine("orderedOddNumbers: " + string.Join(", ", orderedOddNumbers));

//			Console.ReadKey();
//		}
//	}
//}


//class Program
//{
//	static void Main(string[] args)
//	{
//		var words = new List<string> { "a", "bb", "ccc", "dddd" };

//		var shortWords = words.Where(word => word.Length < 3).ToList();

//		Console.WriteLine("First iteration");
//		foreach (var word in shortWords)
//		{
//			Console.WriteLine(word);
//		}
//		words.Add("e");

//		Console.WriteLine("Second iteration");
//		foreach (var word in shortWords)
//		{
//			Console.WriteLine(word);
//		}

//		Console.ReadKey();
//	}
//}



using Microsoft.Graph.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTutorial
{
	class Program
	{
		static void Main(string[] args)
		{
			var numbers = new[] { 5, 9, 2, 12, 6 };
			//bool is7Present = numbers.Contains(7);
			//Console.WriteLine(is7Present);
			var orderedNumbers = numbers.OrderBy(x => x);
			foreach (var number in orderedNumbers)
			{
				Console.WriteLine(number);
			}

			var words = new[] { "lion", "tiger", "snow leopard" };
			//bool isTigerPresent = words.Contains("tiger");
			//Console.WriteLine(isTigerPresent);
			var orderedWords = words.OrderByDescending(x => x);

			foreach (var word in orderedWords)
			{
				Console.WriteLine(word);

			}
			Console.ReadKey();
		}
	}
}


