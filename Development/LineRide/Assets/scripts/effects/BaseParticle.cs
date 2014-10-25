using UnityEngine;
using System.Collections;

public class BaseParticle : MonoBehaviour
{
		public float lifeTime;
		private float age = 0;
		public float startingAlpha = 1;
		public float alphaChange;
		public Vector3 velocity = Vector3.zero;
		public Vector3 acceleration = Vector3.zero;
		public float friction = 1f;
	
		void Start ()
		{
				gameObject.SetSprite (Res.Particle);	
				gameObject.SetAlpha (startingAlpha);
		}

		void Update ()
		{
				if (age >= lifeTime) {
						gameObject.Destroy ();
						return;
				} else {
						age++;
						gameObject.ModifyAlpha (alphaChange);					
				}	
				transform.position += velocity;
				velocity += acceleration;
				velocity *= friction;
		}
}

