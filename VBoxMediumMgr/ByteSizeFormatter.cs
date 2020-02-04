using System;
using System.Globalization;

namespace VBoxMediumMgr
{
	/// <summary>
	/// A custom formatter for byte sizes (things like files, network bandwidth, etc.) that will automatically determine the best abbreviation.
	/// </summary>
	public class ByteSizeFormatter : IFormatProvider, ICustomFormatter
	{
		private static ByteSizeFormatter inst;
		private static readonly string[] suffixes = { " B", " KB", " MB", " GB", " TB", " PB", " EB" };

		/// <summary>Gets a static instance of this class.</summary>
		/// <value>The instance.</value>
		public static ByteSizeFormatter Instance => inst ?? (inst = new ByteSizeFormatter());

		/// <summary>
		/// Converts the value of a specified object to an equivalent string representation using specified format and culture-specific formatting information.
		/// </summary>
		/// <param name="format">A format string containing formatting specifications.</param>
		/// <param name="arg">An object to format.</param>
		/// <param name="formatProvider">An object that supplies format information about the current instance.</param>
		/// <returns>The string representation of the value of <paramref name="arg"/>, formatted as specified by <paramref name="format"/> and <paramref name="formatProvider"/>.</returns>
		public string Format(string format, object arg, IFormatProvider formatProvider)
		{
			ulong bytes = 0;
			try { bytes = Convert.ToUInt64(arg); }
			catch { return HandleOtherFormats(format, arg); }
			if (bytes == 0) return "0" + suffixes[0];
			var m = System.Text.RegularExpressions.Regex.Match(format, "^[B|b](?<prec>\\d+)$");
			if (!m.Success) return HandleOtherFormats(format, arg);
			var prec = m.Groups["prec"].Success ? byte.Parse(m.Groups["prec"].Value) : 0;
			var place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
			if (place >= suffixes.Length) place = suffixes.Length - 1;
			var num = Math.Round(bytes / Math.Pow(1024, place), 1);
			return $"{num.ToString("F" + prec)}{suffixes[place]}";
		}


		/// <summary>Returns an object that provides formatting services for the specified type.</summary>
		/// <param name="formatType">An object that specifies the type of format object to return.</param>
		/// <returns>
		/// An instance of the object specified by <paramref name="formatType"/>, if the IFormatProvider implementation can supply that type
		/// of object; otherwise, <see langword="null"/>.
		/// </returns>
		public object GetFormat(Type formatType) => formatType == typeof(ICustomFormatter) ? this : null;

		private string HandleOtherFormats(string format, object arg) => (arg as IFormattable)?.ToString(format, CultureInfo.CurrentCulture) ?? (arg?.ToString() ?? string.Empty);

		/// <summary>
		/// Tries the parse.
		/// </summary>
		/// <param name="input">The input.</param>
		/// <param name="bytes">The bytes.</param>
		/// <returns></returns>
		/// <exception cref="InvalidOperationException"></exception>
		public static bool TryParse(string input, out long bytes)
		{
			const string expr = @"^\s*(?<num>\d+(?:\.\d+)?)\s*(?<mod>[kKmMgGtTpPeEyY]?[bB])?\s*$";
			var match = System.Text.RegularExpressions.Regex.Match(input, expr);
			bytes = 0;
			if (!match.Success) return false;
			long mult = 1;
			switch (match.Groups["mod"].Value.ToUpper())
			{
				case "B":
				case "":
					break;
				case "KB":
					mult = 1024;
					break;
				case "MB":
					mult = (long)Math.Pow(1024, 2);
					break;
				case "GB":
					mult = (long)Math.Pow(1024, 3);
					break;
				case "TB":
					mult = (long)Math.Pow(1024, 4);
					break;
				case "PB":
					mult = (long)Math.Pow(1024, 5);
					break;
				case "EB":
					mult = (long)Math.Pow(1024, 6);
					break;
				case "YB":
					mult = (long)Math.Pow(1024, 7);
					break;
				default:
					throw new InvalidOperationException();
			}
			bytes = (long)Math.Round(float.Parse(match.Groups["num"].Value) * mult);
			return true;
		}
	}
}