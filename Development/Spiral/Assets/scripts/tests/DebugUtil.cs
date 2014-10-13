using UnityEngine;
using System.Collections;

public class DebugUtil 
{
	public static GameObject AddCircle(Vector2 position){
			GameObject gameObject = new GameObject ();
			SpriteRenderer renderer = gameObject.AddComponent<SpriteRenderer> ();
			Sprite sprite = Sprites.arrow_128;
			renderer.sprite = sprite;
			gameObject.transform.position = position;
			return gameObject;
	}
		
}

