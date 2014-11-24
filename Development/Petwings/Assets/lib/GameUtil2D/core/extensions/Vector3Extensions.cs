using UnityEngine;
using System.Collections;
using GameUtil2D;

public static class Vector3Extensions
{
		public static Vector3 Randomize (this Vector3 vector, Vector3 range)
		{
				float minX = vector.x - range.x;
				float maxX = vector.x + range.x;
				float x = Random.Range (minX, maxX);
		
				float minY = vector.y - range.y;
				float maxY = vector.y + range.y;
				float y = Random.Range (minY, maxY);
		
				return new Vector2 (x, y);
		}

		public static Vector3 Randomize (this Vector3 vector, float range)
		{
				float amount = Random.Range (-range, range);
				return new Vector3 (vector.x + amount, vector.y + amount);
		}

}

