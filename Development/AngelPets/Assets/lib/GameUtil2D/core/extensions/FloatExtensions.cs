using UnityEngine;
using System.Collections;

public static class FloatExtensions
{
	public static float TIME = 1.0f;

	public static float RealVal(this float value){
		return value * TIME;
	} 

	public static float GiveOrTake(this float value, float amount){
		return Random.Range(value - amount, value + amount);
	}
}

