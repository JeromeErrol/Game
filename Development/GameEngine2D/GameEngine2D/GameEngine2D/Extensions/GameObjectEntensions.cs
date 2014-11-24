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
				color.a = Mathf.Max (0, Mathf.Min (1, color.a + changeValue));
				gameobject.renderer.material.color = color;
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
				return gameobject.transform.position.x - (gameobject.Width () / 2f);
		}

		public static float Right (this GameObject gameobject)
		{
				return gameobject.transform.position.x + gameobject.GetComponent<SpriteRenderer> ().bounds.min.x;
		}

		public static T GetOrCreateComponent<T> (this GameObject gameObject)where T:Component
		{
				T componant = gameObject.GetComponent<T> ();
				if (componant == null) {
						componant = gameObject.AddComponent<T> ();
				}
				return componant;
		}

		public static Sprite GetSprite (this GameObject gameObject)
		{
				SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer> ();
				if (spriteRenderer != null) {
						return spriteRenderer.sprite;
				} else {
						return null;
				}
		}

		public static void SetSprite (this GameObject gameObject, Sprite sprite)
		{
				GetOrCreateComponent<SpriteRenderer> (gameObject).sprite = sprite;
		}

		public static Color GetColor (this GameObject gameObject)
		{
				return gameObject.GetComponent<SpriteRenderer> ().color;
		}

		public static Color SetColor (this GameObject gameObject, Color color)
		{
				return gameObject.GetComponent<SpriteRenderer> ().color = color;
		}

		public static void Destroy (this GameObject gameObject)
		{
				GameObject.Destroy (gameObject);
		}

		public static float Width (this GameObject gameObject)
		{
				SpriteRenderer r = gameObject.GetComponent<SpriteRenderer> ();
				return r.bounds.max.x - r.bounds.min.x;
		}

		public static float Height (this GameObject gameObject)
		{
				SpriteRenderer r = gameObject.GetComponent<SpriteRenderer> ();
				return r.bounds.max.y - r.bounds.min.y;
		}

		public static Vector3 ScreenPosition (this GameObject gameObject)
		{
				return Camera.main.WorldToScreenPoint (gameObject.transform.position);
		}

		public static void AddChild (this GameObject thisGameObject, GameObject gameObject)
		{
				gameObject.transform.parent = thisGameObject.transform;
		}
}

