using UnityEngine;
using System.Collections;

public class SpeedLine : MonoBehaviour
{
		private Vector3 previousPosition;
		private float maxSpeed = 0.1499977f;


		void Start ()
		{
			previousPosition = transform.position;
		}

		void FixedUpdate ()
		{
			float alpha = 0;

			if (transform.position.x < previousPosition.x) {				
				transform.localScale = new Vector3 (-1, 1, 1);
			} else {
				transform.localScale = new Vector3(1, 1, 1);
			}
			float distance = Vector3.Distance (previousPosition, transform.position);
			alpha = ((distance / maxSpeed) +gameObject.GetAlpha()) / 2f;	

			gameObject.SetAlpha (alpha);
			previousPosition = gameObject.transform.position;
		
	}
}

