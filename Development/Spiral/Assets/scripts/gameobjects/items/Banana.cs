using UnityEngine;
using System.Collections;

public class Banana 
{
		public Banana()
		{
			GameObject gameObject = new GameObject ();
			SpriteRenderer renderer = gameObject.AddComponent<SpriteRenderer> ();
			gameObject.AddComponent<Item> ();
			renderer.sprite = Sprites.banana_x1;
			gameObject.transform.position = GameObject.Find("SpawnPosition").transform.position;
		}
}

