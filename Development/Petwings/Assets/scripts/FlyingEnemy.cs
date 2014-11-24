using UnityEngine;
using System.Collections;

public class FlyingEnemy : MonoBehaviour
{
		private Vector3 previousPosition;

		// Use this for initialization
		void Start ()
		{
				previousPosition = transform.position;
		}
	
		// Update is called once per frame
		void Update ()
		{
				Vector3 velocity = transform.position - previousPosition;
				
				if (Mathf.Abs (velocity.x) > 0) {
						Vector3 scale = transform.localScale;
						if (velocity.x < 0) {
								scale.x = - Mathf.Abs (scale.x);
						} else {
								scale.x = Mathf.Abs (scale.x);
						}
						transform.localScale = scale;
				}
				previousPosition = transform.position;
		}
}

