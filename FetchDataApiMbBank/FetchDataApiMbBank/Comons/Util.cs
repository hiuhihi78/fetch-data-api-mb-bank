namespace FetchDataApiMbBank.Comons
{
	public static class Util
	{
		public static (DateTime?, DateTime?) PaserDateTimeFromDateToDate(string? fromDate, string? toDate)
		{
			DateTime from;
			DateTime to;
			string format = "dd/MM/yyyy";
			try
			{
				from = DateTime.ParseExact(fromDate, format, System.Globalization.CultureInfo.InvariantCulture);
				to = DateTime.ParseExact(toDate, format, System.Globalization.CultureInfo.InvariantCulture).AddDays(1);
				if (from > to) return (null, null);
				return (from, to);
			}
			catch (FormatException)
			{
				return (null, null);
			}
		}
	}
}
