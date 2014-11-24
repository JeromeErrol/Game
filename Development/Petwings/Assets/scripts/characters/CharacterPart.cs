using UnityEngine;
using System.Collections;

public class CharacterPart : MonoBehaviour
{
		public Vector3 relativePosition;
		public GameObject owner;

		void FixedUpdate ()
		{
			gameObject.transform.position = owner.transform.position + relativePosition;
		}
}

