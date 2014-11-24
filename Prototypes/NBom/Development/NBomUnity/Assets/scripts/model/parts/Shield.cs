using UnityEngine;

public class Shield: MonoBehaviour
{
		public float strength;

		public Shield ()
		{

		}

		void Update ()
		{
				SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
				if (Active) {
						strength--;
						spriteRenderer.color = Color.red;
				} else {
					spriteRenderer.color = Color.white;
				}
		}		

		public bool Active {
				get {
						return strength > 0;
				}
		}
}

