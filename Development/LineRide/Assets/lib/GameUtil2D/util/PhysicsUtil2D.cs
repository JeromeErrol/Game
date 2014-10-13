using UnityEngine;
using System.Collections;
using System;

namespace GameUtil2D
{	
		public static class PhysicsUtil2D
		{
				public static void ApplyForwardForce (Rigidbody2D rigidBody2D, float amount)
				{
						ApplyDirectedForce (rigidBody2D, rigidBody2D.transform.rotation, amount);
				}
	
				public static void ApplyDirectedForce (Rigidbody2D rigidBody2D, Quaternion rotation, float amount)
				{
						rigidBody2D.AddForce (rotation * Vector3.up * amount);
				}
	
				public static void TranslateForwards (Rigidbody2D rigidBody2d, float distance)
				{						
						Vector2 velocity = GetVelocity (Mathf.Deg2Rad * rigidBody2d.rotation, distance);
						rigidBody2d.transform.position += new Vector3 (velocity.x, velocity.y, 0);
				}
	
				public static void TranslateTowards (GameObject gameObject, float radions, float distance)
				{
						Vector2 displacement = PhysicsUtil2D.GetVelocity (radions, distance);
						gameObject.transform.position += new Vector3 (displacement.x, displacement.y, 0);
				}
	
				public static Vector2 GetVelocity (float radions, float speed)
				{
						float opp = (speed * Mathf.Sin (radions));
						float adj = (speed * Mathf.Cos (radions));
						return new Vector2 (adj, opp);
				}
	
				public static float GetRadions (Vector3 velocity)
				{
						return	Mathf.Atan ((velocity.x / velocity.y));
				}
		}
}