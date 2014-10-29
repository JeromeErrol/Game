using UnityEngine;
using System.Collections;
using GameUtil2D;

public class ParticleGenerator : MonoBehaviour
{
		public int framesPerShot;
		public int particleLifeTime;
		private int currentFrame = 0;
		public float alpha = 1;
		public float alphaChange;
		public Vector3 accelerate;
		public Vector2 accelerationRange;
		public Vector3 velocity;
		public Vector2 velocityRange;
		public Vector3 scale;
		public float scaleRange;
		public Vector3 scaleChange;
		public float friction = 1;
		public Color color = Color.white;
		public Sprite sprite;
		public Vector2 spawnRange;
		public int orderInLayer;
		public string particleName;
	
		void Update ()
		{
				if (currentFrame >= framesPerShot) {
						Fire ();
						currentFrame = 0;
				} else {
						currentFrame++;
				}
		}

		void Fire ()
		{
				GameObject go = new GameObject ();
				go.transform.position = transform.position.Randomize (spawnRange);
				BaseParticle smoke = go.AddComponent<BaseParticle> ();					
				smoke.lifeTime = particleLifeTime;
				smoke.alpha = alpha;
				smoke.alphaChange = alphaChange;
				smoke.acceleration = accelerate.Randomize (accelerationRange);
				smoke.velocity = velocity.Randomize (velocityRange);
				smoke.friction = friction;
				smoke.scaleChange = scaleChange;
				SpriteRenderer r = smoke.gameObject.GetOrCreateComponent<SpriteRenderer> ();
				r.material.color = color;
				smoke.sprite = sprite;
				smoke.scale = scale.Randomize (scaleRange);
				r.sortingOrder = orderInLayer;
				go.name = particleName;			
			
		}
}

