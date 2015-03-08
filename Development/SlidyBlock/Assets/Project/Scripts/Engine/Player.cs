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

		public static float PositionX {
				get {
						return instance.transform.position.x;
				}set {
						Vector3 position = instance.transform.position;
						position.x = value;
						instance.transform.position = position;
				}
		}
}

