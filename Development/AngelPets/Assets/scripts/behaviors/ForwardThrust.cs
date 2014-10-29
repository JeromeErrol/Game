using UnityEngine;
using System.Collections;
using GameUtil2D;

public class ForwardThrust : MonoBehaviour{
	
	public float inTime;
	public float shootOutTime;	
	public float outTime;
	public float retractTime;
	public float distance;
	
	
	public float currentFrame;
	
	private float CurrentSpeed{
		get{
			if(currentFrame <= inTime){
				return 0;
			}
			if(currentFrame <= inTime + shootOutTime){
				return distance / shootOutTime;
			}
			if(currentFrame <= inTime + shootOutTime + outTime){
				return 0;
			}else{
				return -(distance / retractTime);
			}
		}
	}
	
	void Update ()
	{
		currentFrame = (currentFrame + 1) % (inTime + shootOutTime + outTime + retractTime);
		PhysicsUtil2D.TranslateForwards (gameObject.rigidbody2D, CurrentSpeed);
	}
}

