using UnityEngine;
using System.Collections;

// http://www.mathamazement.com/Lessons/Pre-Calculus/06_Additional-Topics-in-Trigonometry/polar-coordinates.html
public class Spiral 
{
	public static float GetRadius(float x, float y){
		return Mathf.Sqrt((x * x) * (y * y));
	}

	public static Vector2 ToVector2(float distance, float angle){
		float x = distance * Mathf.Cos (angle);
		float y = distance * Mathf.Sin (angle);
		return new Vector2 (x, y);
	}
}

