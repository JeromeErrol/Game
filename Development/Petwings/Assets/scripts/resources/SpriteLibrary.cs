using UnityEngine;
using System.Collections;

public class SpriteLibrary : MonoBehaviour
{
		public static SpriteLibrary Instance;
		public Sprite circle;

		void Awake ()
		{
				SpriteLibrary.Instance = this;
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
}

