using UnityEngine;
using System.Collections;

public class MaintainVelocity : MonoBehaviour
{
		public GameObject2D gameObject2D;
		public Vector2 velocity;

		void Start ()
		{
				if (gameObject2D == null) {
						gameObject2D = gameObject.GetOrCreateComponent<GameObject2D> ();	
				}
		}
	
		void FixedUpdate ()
		{
				if (!Game.Instance.Paused) {
						gameObject2D.velocity = velocity;
				}
		}
}

