using System;
using System.Globalization;
using System.Linq;

namespace HelloSortSample 
{
	public static class Program 
	{
		public static void Main() 
		{
		    string[] mineOrd ={ "aa","ab", "ac", "åå" };
			skrivut(mineOrd, "Start");
			
            Array.Sort(mineOrd);
			var culture = new CultureInfo("nn-NO", true);
			mineOrd =  mineOrd.OrderBy(d => d, StringComparer.Create(culture, false)).ToArray();
		    skrivut(mineOrd, "Sortert");
			
		}
		
		static void skrivut(string[] ordene,string kommentar)
		{
			Console.WriteLine("\n" + kommentar);
			foreach (string ord in ordene)
			{
				Console.WriteLine(ord);
			}
		}
	}
}