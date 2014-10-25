using UnityEngine;
using System.Collections;
using GameUtil2D;

public class SmokeGenerator : MonoBehaviour
{
		public int framesPerShot;
		public int particleLifeTime;
		private int currentFrame = 0;
		public float alphaChange;
		public Vector3 accelerate;
		public Vector3 velocity;
		public float friction = 1;
		public Color color = Color.white;
		

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
				go.transform.position = transform.position;
				BaseParticle smoke = go.AddComponent<BaseParticle> ();					
				smoke.lifeTime = particleLifeTime;
				smoke.alphaChange = alphaChange;
				smoke.velocity = Vector3.zero;
				smoke.acceleration = accelerate;
				smoke.velocity = velocity;
				smoke.friction = friction;
				smoke.gameObject.GetOrCreateComponent<SpriteRenderer> ().material.color = color;
		}
}

