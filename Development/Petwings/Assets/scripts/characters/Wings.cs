using UnityEngine;
using System.Collections;

public class Wings : MonoBehaviour
{
		public float averageHeight;
		public float peakHeight;
		public float speed;
		private float direction = 1f;

		void FixedUpdate ()
		{
				Movement movement = gameObject.GetOrCreateComponent<Movement> ();
				movement.acceleration.y += speed * direction;
				
				if (movement.position.y > averageHeight + peakHeight) {
						direction = -1;
				} else if (movement.position.y < averageHeight - peakHeight) {
						direction = 1;
				}
		}
}

