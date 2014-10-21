using UnityEngine;
using System.Collections;

public static class GameObjectEntensions
{
		public static float GetAlpha (this GameObject gameobject)
		{
				return gameobject.renderer.material.color.a;
		}

		public static void SetAlpha (this GameObject gameobject, float value)
		{
				Color color = gameobject.renderer.material.color;
				color.a = value;
				gameobject.renderer.material.color = color;
		}

		public static void ModifyAlpha (this GameObject gameobject, float changeValue)
		{
				Color color = gameobject.renderer.material.color;
				color.a = color.a + changeValue;
				gameobject.renderer.material.color = color;
		}

		public static float X (this GameObject gameobject)
		{
				return gameobject.transform.position.x;
		}

		public static void X (this GameObject gameobject, float value)
		{
				Vector3 pos = gameobject.transform.position;
				pos.x = value;
				gameobject.transform.position = pos;
		}

		public static float Y (this GameObject gameobject)
		{
				return gameobject.transform.position.y;
		}
	
		public static void Y (this GameObject gameobject, float value)
		{
				Vector3 pos = gameobject.transform.position;
				pos.y = value;
				gameobject.transform.position = pos;
		}
	
		public static float Bottom (this GameObject gameobject)
		{
				return gameobject.transform.position.y + gameobject.GetComponent<SpriteRenderer> ().bounds.min.y;
		}

		public static float Top (this GameObject gameobject)
		{
				return gameobject.transform.position.y + gameobject.GetComponent<SpriteRenderer> ().bounds.max.y;
		}

		public static float Left (this GameObject gameobject)
		{
				return gameobject.transform.position.x + gameobject.GetComponent<SpriteRenderer> ().bounds.min.x;
		}

		public static float Right (this GameObject gameobject)
		{
				return gameobject.transform.position.x + gameobject.GetComponent<SpriteRenderer> ().bounds.min.x;
		}
}

