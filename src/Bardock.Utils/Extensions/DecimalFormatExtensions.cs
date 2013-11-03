﻿using System.Runtime.CompilerServices;
using System.Globalization;
using Bardock.Utils.Globalization;

namespace Bardock.Utils.Extensions
{

    public static class DecimalFormatExtensions
	{

		/// <summary>
		/// Returns string representation with currency format without symbol
		/// </summary>
        public static string ToCurrencyString(this decimal d)
		{
			return d.ToString("#,0.00");
		}

		/// <summary>
		/// Returns string representation with currency format without symbol neither thousands separator
		/// </summary>
        public static string ToCurrencyInputString(this decimal d)
		{
			return d.ToString("0.00");
		}

		/// <summary>
		/// Returns string representation with default format (English)
		/// </summary>
        public static string ToDefaultFormat(this decimal d)
		{
            using ((new ContextCulture()))
            {
				return d.ToString();
			}
		}

        public static NumberFormatInfo CurrentFormatInfo
        {
			get { return System.Globalization.CultureInfo.CurrentCulture.NumberFormat; }
		}

	}

}