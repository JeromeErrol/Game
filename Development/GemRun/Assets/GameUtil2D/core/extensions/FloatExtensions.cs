using UnityEngine;
using System.Collections;

public static class FloatExtensions
{
	public static float GiveOrTake(this float value, float amount){
		return Random.Range(value - amount, value + amount);
	}
}

