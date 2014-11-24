using UnityEngine;
using System.Collections;

public class Stage : MonoBehaviour
{
		public float movementSpeed = 0.05f;

	
		// Update is called once per frame
		void Update ()
		{
				Vector3 pos = transform.position;
				pos.x -= movementSpeed;
				transform.position = pos;
		}
}

