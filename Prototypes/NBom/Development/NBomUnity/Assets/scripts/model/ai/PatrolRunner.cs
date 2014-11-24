using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PatrolRunner : MonoBehaviour
{
		public List<GameObject> patrolPoints = new List<GameObject> ();
		public float movementSpeed;
		private int _currentIndex = 0;
		public int startingIndex;
		public float targetRadius = 5;
		public float pauseTime;
		private float pauseTimeRemaining;

		// Use this for initialization
		void Start ()
		{
				_currentIndex = startingIndex;
		}
	
		// Update is called once per frame
		void Update ()
		{
				RemoveNullObjectsFromList ();
				float distance = Vector3.Distance (rigidbody2D.position, targetPosition);

				if (distance <= targetRadius) {
						currentIndex++;
						pauseTimeRemaining = pauseTime;
				}
				if (pauseTimeRemaining <= 0) {
						
						transform.position = Vector3.MoveTowards (transform.position, targetPosition, movementSpeed);
				} else {
						pauseTimeRemaining--;
				}
		}

		void RemoveNullObjectsFromList ()
		{
				for (int i = 0; i < patrolPoints.Count; i++) {
						GameObject target = patrolPoints [i];
						if (target == null) {
								patrolPoints.RemoveAt (i);
								i = Mathf.Max(i - 1 , 0);							
						}
				}
		}

		Vector3 targetPosition {
				get {
						if (patrolPoints.Count > 0) {
								GameObject target = patrolPoints [currentIndex];
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
