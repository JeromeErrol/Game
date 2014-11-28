using UnityEngine;
using System.Collections;

public class Force2D : MonoBehaviour
{
		public GameObject2D target;
		public Vector2 value;

		void FixedUpdate ()
		{
				target.acceleration += value;
		}
}

