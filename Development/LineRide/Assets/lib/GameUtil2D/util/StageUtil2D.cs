using UnityEngine;
using System.Collections;
using System;

namespace GameUtil2D
{
		public static class StageUtil2D
		{					
				public static GameObject AddGameObject (Sprite sprite, Vector3 position)
				{
						GameObject gameObject = new GameObject ();
						SpriteRenderer renderer = gameObject.AddComponent<SpriteRenderer> ();
						renderer.sprite = sprite;
						gameObject.transform.position = position;
						return gameObject;
				}
	
				public static GameObject AddGameObject (String texture, Vector3 position)
				{
						return AddGameObject (Resources.LoadAssetAtPath<Sprite> (texture), position);			
				}
		}
}

