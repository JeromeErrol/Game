using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScaleAutomation : MonoBehaviour
{
		public Vector3 minScale;
		public Vector3 maxScale;
		private float divisions = 100;
		private int direction;
		

		void Start ()
		{
			direction = 1;
			gameObject.transform.localScale = minScale;
		}

		void Update ()
		{
			Vector3 acceleration = (maxScale - minScale) / divisions;
			gameObject.transform.localScale += acceleration;

			if (transform.localScale.x > maxScale.x) {
				direction = -1;
			}
		}
}

