using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using GameUtil2D;

public class Patrol : MonoBehaviour
{	
	public List<GameObject> patrolPoints = new List<GameObject> ();
	public float movementSpeed;
	private int _currentIndex = 0;
	public int startingIndex;
	public float targetRadius = 5;
	public float pauseTime;
	private float pauseTimeRemaining;
	public bool spinOnPause = true;

	void Start ()
	{
		_currentIndex = startingIndex;
	}

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
			if(spinOnPause){
				Vector3 e = gameObject.transform.eulerAngles;
				e.z += spinSpeed;
				gameObject.transform.eulerAngles = e;
			}
		}
	}

	float spinSpeed{
		get{
			return (180f) / pauseTime;
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
