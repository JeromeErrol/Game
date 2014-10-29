using UnityEngine;
using System.Collections;

public class Smoothen : MonoBehaviour
{
		private Vector3 previousPos;
		private Vector3 previousPosB;

		void Start ()
		{
			previousPos = gameObject.transform.position;
			previousPosB = gameObject.transform.position;
		}

		void FixedUpdate ()
		{
			Vector3 pos = transform.position;
			Vector3 average = (pos + previousPos) / 2f;
			gameObject.transform.position = average;
			previousPos = pos;
		}

		void Update(){
			Vector3 pos = transform.position;
			Vector3 average = (pos + previousPosB) / 2f;
			gameObject.transform.position = average;
			previousPosB = pos;
		}
}

