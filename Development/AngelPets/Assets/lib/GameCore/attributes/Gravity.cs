using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour
{
		public float strength = 0.007f;

		void FixedUpdate ()
		{
				gameObject.GetOrCreateComponent<Movement> ().acceleration.y -= strength;
		}
}

