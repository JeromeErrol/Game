using UnityEngine;
using System.Collections;

public class Velocity : MonoBehaviour
{
		float acceleration = 0;
		public float friction = 0.95f;
		float velocity = 0;

		void Start ()
		{
	
		}

		public void AddAcceleration(float amount){
			acceleration += amount;
		}

		public float Vel{
			get{
				return velocity;
			}
		}

		void FixedUpdate ()
		{
				velocity += acceleration;
				acceleration = 0;
				velocity *= friction;

				Vector3 pos = transform.position;
				pos.x += velocity;
				transform.position = pos;
		}
}

