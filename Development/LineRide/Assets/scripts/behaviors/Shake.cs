using UnityEngine;
using System.Collections;

public class Shake : MonoBehaviour
{
		public Vector3 intensity;
		private Vector3 previousShake = Vector3.zero;


		void Update ()
		{
				gameObject.transform.position -= previousShake;
				previousShake = Vector3.zero.Randomize(intensity);
				gameObject.transform.position += previousShake;
		}
}

