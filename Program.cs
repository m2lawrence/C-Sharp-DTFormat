// The date and time specifiers. Page 401.

using System;
namespace DTFormat
{
	class DTFormat
	{
		public static void Main(string[] args)
		{
			DateTime CurrTime = DateTime.Now;
			
			Console.WriteLine("Mikes date and time specifiers.\n");
			Console.WriteLine("d: {0:d}", CurrTime ); //Short date
			Console.WriteLine("D: {0:D}", CurrTime ); //Long date
			Console.WriteLine("f: {0:f}", CurrTime ); //Full date/short time
			Console.WriteLine("F: {0:F}", CurrTime ); //Full date/full time
			Console.WriteLine("g: {0:g}", CurrTime ); //Short date/short time 
			Console.WriteLine("G: {0:G}", CurrTime ); //Short date/long time
			Console.WriteLine("m: {0:m}", CurrTime ); //Month day
			Console.WriteLine("M: {0:M}", CurrTime ); //Month day
			Console.WriteLine("r: {0:r}", CurrTime ); //RFC1123
			Console.WriteLine("R: {0:R}", CurrTime ); //RFC1123
			Console.WriteLine("s: {0:s}", CurrTime ); //not big S, and means Sortable.                     
			Console.WriteLine("t: {0:t}", CurrTime ); //Short time
			Console.WriteLine("T: {0:T}", CurrTime ); //Long time
			Console.WriteLine("u: {0:u}", CurrTime ); //Sortable (universal)
			Console.WriteLine("U: {0:U}", CurrTime ); //Sortable (universal)
			Console.WriteLine("y: {0:y}", CurrTime ); //Year/month
			Console.WriteLine("Y: {0:Y}", CurrTime ); //Year/month
			Console.ReadKey(true);
		}
	}
}


