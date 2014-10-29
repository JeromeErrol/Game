using UnityEngine;
using System.Collections;

public abstract class TargetedCondition : Condition
{
	public GameObject target;

	void Start(){
		if (target == null) {
			target = gameObject;
		}
	}
	
}

