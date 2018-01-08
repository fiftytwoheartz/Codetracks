﻿using System;

namespace Codetracks.Core
{
	public static class Predicates
	{
		public static class Int32
		{
			public static Tuple<Func<int, bool>, string> Positive => Tuple.Create<Func<int, bool>, string>(arg => arg >= 0, $"Expected positive {nameof(Int32)}.");
			public static Tuple<Func<int, bool>, string> Negative => Tuple.Create<Func<int, bool>, string>(arg => arg < 0, $"Expected negative {nameof(Int32)}.");
		}

	}
}