using UnityEngine;
using System.Collections;

public class Torque2D : MonoBehaviour
{
		public GameObject2D target;
		public float value;
	
		void Start ()
		{
				if (target == null) {
						target = gameObject.GetOrCreateComponent<GameObject2D> ();
				}
		}
	
		void FixedUpdate ()
		{
				target.rotationAcceleration += value;
		}
}

