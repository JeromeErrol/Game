using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour
{
		public float value;

		void Start(){
			
		}

		void Update ()
		{
				Vector3 angle = gameObject.transform.eulerAngles;
				angle.z = value;
				gameObject.transform.eulerAngles = angle;
		}

		public void RotateBy (float degrees)
		{
			value += (degrees * (gameObject.GetOrCreateComponent<Speed> ().RelativeSpeed)); 
		}
}

