using UnityEngine;
using System.Collections;

public class ConstrainAngle : MonoBehaviour
{
		public float minAngle;
		public float maxAngle;
		
		void Start ()
		{
			
		}	
		
		void Update ()
		{
			Vector3 q = transform.eulerAngles;
			float angle = q.z;
			if(angle > maxAngle){
				angle = maxAngle;
			}
			if (angle < minAngle) {
				angle = minAngle;
			}
			q.z = angle;			
			transform.eulerAngles = q;
		}
}

