using UnityEngine;
using AssemblyCSharp;
using System;

namespace AssemblyCSharp
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
				public static Vector3 GetVelocity (float angle, float speed)
				{
						Vector3 velocity = Vector3.zero;
						velocity.x = speed * Mathf.Cos (angle * Mathf.PI / 180);
						velocity.y += speed * Mathf.Sin (angle * Mathf.PI / 180);
						return velocity;
				}
		}
}

