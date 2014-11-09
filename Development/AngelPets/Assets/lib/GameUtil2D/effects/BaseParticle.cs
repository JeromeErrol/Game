using UnityEngine;
using System.Collections;

public class BaseParticle : MonoBehaviour
{
		public float lifeTime;
		private float age = 0;
		public float alpha = 1;
		public float alphaChange;
		public Vector3 velocity = Vector3.zero;
		public Vector3 acceleration = Vector3.zero;
		public float friction = 1f;
		public Sprite sprite;
		public Vector3 scale;
		public Vector3 scaleChange;
	
		void Start ()
		{
				gameObject.name = "Particle";
				gameObject.SetSprite (sprite);	
				gameObject.SetAlpha (alpha);
				gameObject.transform.localScale = scale;
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
				gameObject.transform.localScale += scaleChange;
		}
}

