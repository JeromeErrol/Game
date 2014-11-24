using UnityEngine;
using System.Collections;

public class AutomaticDoor : MonoBehaviour
{		
		private float rotationSpeed;	
		public float openAngle;
		public float closedAngle;
		public float timeToOpen;
		public float pauseTime;

		void Start ()
		{
			
		}

		float openingSpeed{
			get{
				return (closedAngle - openAngle) / timeToOpen;
			}
		}

		void Update ()
		{
			if (rotationSpeed == openingSpeed && angle != openAngle ) {			
				transform.Rotate (new Vector3(0, 0, rotationSpeed));
			}

			
		}

		float angle{
			get{
			return transform.eulerAngles.z;
			}
		}
	
		public void Open(){
			rotationSpeed = openingSpeed;
		}
}

