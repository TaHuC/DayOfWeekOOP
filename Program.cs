using System;
using System.Globalization;

namespace DayOfWeekOOP
{
	public class MainClass
	{
		public static void Main()
		{
			DateTime dayOfWeek = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy",
			                                         CultureInfo.InvariantCulture);

			Console.WriteLine(dayOfWeek.DayOfWeek);

		}
	}
}
