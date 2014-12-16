using UnityEngine;
using System.Collections;
using UnityUtil.Extensions;

public class Player : MonoBehaviour
{
		PlayMakerFSM fsm;
		public static Player instance;
		public float speed;

		void Awake ()
		{
				instance = this;
				fsm = GetComponent<PlayMakerFSM> ();
		}

		void FixedUpdate ()
		{
				if (transform.position.x < -9.299999f) {
						gameObject.X (-9.299999f);
				}
		}

		public void GoLeft ()
		{
				Velocity = -Speed;
		}

		private float Speed {
				get {
						return (Time.deltaTime * 60) * speed;
				}
		}

		private float Velocity {
				get {
						return rigidbody2D.velocity.x;
				}set {
						Vector2 velocity = rigidbody2D.velocity;
						velocity.x = value;	
						rigidbody2D.velocity = velocity;
				}
		}

		public void GoRight ()
		{
				Velocity = Speed;
		}
    
		public void Stand ()
		{
				Velocity = 0;
		}

		public static Vector3 Position {
				get {
						return instance.transform.position;
				}set {
						instance.transform.position = value;
				}
		}
}

