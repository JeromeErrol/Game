using UnityEngine;
using System.Collections;
using GameUtil2D;

public class OpenCloseDoor : EventAction
{
	float angle = 0;
	float pause;
	
	public float turnTime = 120;
	public float pauseTotal;
	public float rotationAmount = 90;
	public bool fired = false;

	public override void Fire ()
	{
		fired = true;
	}

	private float changePerFrame{
		get{
			return this.turnTime / this.rotationAmount;
		}
	}

	void Update(){
		if (fired) {
			GOUtil2D.AddRotation (gameObject, changePerFrame);
		}
	}
}

