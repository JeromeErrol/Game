using UnityEngine;
using System.Collections;
using System;

namespace GameUtil2D
{
		public static class StageUtil2D
		{					
				public static GameObject AddGameObject (Sprite sprite)
				{
						GameObject gameObject = new GameObject ();
						SpriteRenderer renderer = gameObject.AddComponent<SpriteRenderer> ();
						renderer.sprite = sprite;
						return gameObject;
				}
	
				public static GameObject AddGameObject (String texture)
				{
						return AddGameObject (Resources.LoadAssetAtPath<Sprite> (texture));			
				}
		}
}

