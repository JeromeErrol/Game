using UnityEngine;
using System;

namespace GameUtil2D
{
		public static class MouseUtil2D
		{
				public static void FaceMouse (GameObject gameObject)
				{
						Vector3 screenPos = Camera.main.WorldToScreenPoint (gameObject.transform.position);
						gameObject.transform.rotation = Quaternion.Euler (0, 0, Mathf.Atan2 (Input.mousePosition.y - screenPos.y, Input.mousePosition.x - screenPos.x) * Mathf.Rad2Deg - 90);
				}
		}

		public static class PhysicsUtil2D
		{
				public static void ApplyForwardForce(Rigidbody2D rigidBody2D, float amount){
					rigidBody2D.AddForce (rigidBody2D.transform.rotation * Vector3.up * amount);
				}
		}
}

