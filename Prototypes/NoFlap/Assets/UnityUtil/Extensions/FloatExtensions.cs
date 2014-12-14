using UnityEngine;
using System.Collections;

namespace UnityUtil.Extensions
{
		public static class FloatExtensions
		{
				public static float GiveOrTake (this float value, float amount)
				{
						return Random.Range (value - amount, value + amount);
				}
	
				public static bool IsBetween (this float value, float a, float b)
				{
						float max = Mathf.Max (a, b);
						float min = Mathf.Min (a, b);
						return (value <= max && value >= min);
				}
		}
}

