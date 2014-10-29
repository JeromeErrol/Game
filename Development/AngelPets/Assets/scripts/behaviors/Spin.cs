using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour
{
		public float speed;

		void Update ()
		{
				Vector3 angle = transform.eulerAngles;
				angle.z += speed;
				transform.eulerAngles = angle;
		}
}

