using UnityEngine;
using System.Collections;

public class CharacterPart : MonoBehaviour
{
		public Vector3 relativePosition;

		void FixedUpdate ()
		{
				gameObject.transform.position = GameObject.Find ("Player").transform.position + relativePosition;
		}
}

