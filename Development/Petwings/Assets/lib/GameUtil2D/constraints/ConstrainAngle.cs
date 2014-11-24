using UnityEngine;
using System.Collections;

public class ConstrainAngle : MonoBehaviour
{
		public float minAngle;
		public float maxAngle;
		private const float displacement = (360 * 10);

		void Start ()
		{
				Vector3 q = transform.eulerAngles;
				q.z += displacement;
				transform.eulerAngles = q;
				minAngle += displacement;
				maxAngle += displacement;
		}

		void Update ()
		{
				Vector3 q = transform.eulerAngles;
				float angle = Mathf.Abs(q.z) + displacement;

				if (angle < minAngle) {
						angle = minAngle;
				}

				if (angle > maxAngle) {
						angle = maxAngle;
				}
				q.z = angle;	
				transform.eulerAngles = q;
		}
}

