using UnityEngine;
using System.Collections;
using System;

namespace GameUtil2D
{
		public static class MathUtil2D
		{
				public const float HALF_PI = Mathf.PI / 2f;
	
				public static float RoundOff (float value, float roundTo)
				{
		
						float remaining = value % roundTo;	
						float halfway = roundTo / 2f;
		
						int divisions = (int)(value / roundTo);
		
						if (Math.Abs (remaining) >= halfway) {
								// Round up
								if (remaining >= 0) {
										return (divisions + 1) * roundTo;	
								} else {
										if (divisions >= 0) {
												return (divisions + 1) * -roundTo;	
										}
										return (divisions - 1) * roundTo;	
								}									
						} else {
								// Round down
								return (divisions) * roundTo;				
						}				
				}
		}
}
