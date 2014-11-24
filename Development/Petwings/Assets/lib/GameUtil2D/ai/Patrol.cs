using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Patrol : MonoBehaviour
{	
		public List<GameObject> patrolPoints = new List<GameObject> ();
		public float movementSpeed = 0.1f;
		private int _currentIndex = 0;
		public int startingIndex;
		public float pauseTime;
		private float pauseTimeRemaining;
		public bool spinOnPause = true;

		void Start ()
		{
				_currentIndex = startingIndex;
		}

		public GameObject target {
				get {
						return patrolPoints [currentIndex];
				}
		}

		void Update ()
		{
				RemoveNullObjectsFromList ();
				
				float distance = Vector3.Distance (rigidbody2D.position, targetPosition);
		
			if (distance <= movementSpeed + 0.01f) {						
						currentIndex++;
						pauseTimeRemaining = pauseTime;
				}
			if (pauseTimeRemaining <= 0) {			
						transform.position = Vector3.MoveTowards (transform.position, targetPosition, movementSpeed);
				} else {
						pauseTimeRemaining--;
						if (spinOnPause) {
								Vector3 e = gameObject.transform.eulerAngles;
								e.z += spinSpeed;
								gameObject.transform.eulerAngles = e;
						}
								
				}
		}

		float spinSpeed {
				get {
						return (180f) / pauseTime;
				}
		}
	
		void RemoveNullObjectsFromList ()
		{
				for (int i = 0; i < patrolPoints.Count; i++) {
						GameObject target = patrolPoints [i];
						if (target == null) {
								patrolPoints.RemoveAt (i);
								i = Mathf.Max (i - 1, 0);							
						}
				}
		}
	
		Vector3 targetPosition {
				get {
						if (patrolPoints.Count > 0) {
								if (target != null) {
										return target.transform.position;
								} else {
										patrolPoints.RemoveAt (currentIndex);
								}
						}
						return transform.position;
				}
		}
	
		int currentIndex {
				get {
						return _currentIndex;
				}set {
						_currentIndex = (int)Mathf.Max ((value) % patrolPoints.Count, 0);
				}
		}
}
