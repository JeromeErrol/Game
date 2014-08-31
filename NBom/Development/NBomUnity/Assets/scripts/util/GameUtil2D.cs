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

		public static class TrigUtil2D
		{
				public static Vector2 GetVelocity (float angle, float speed)
				{
						Vector2 velocity = Vector2.zero;
						velocity.x = speed * Mathf.Cos (angle * Mathf.PI / 180);
						velocity.y += speed * Mathf.Sin (angle * Mathf.PI / 180);
						return velocity;
				}
		}
}

