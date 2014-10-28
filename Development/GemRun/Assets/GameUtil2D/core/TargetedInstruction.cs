using UnityEngine;
using System.Collections;

public abstract class TargetedInstruction : Instruction
{
	public GameObject target;

	void Start(){
		if (target == null) {
			target = gameObject;
		}
	}

	public GameObject Target{
		get{
			if(target == null){
				target = gameObject;
			}
			return target;
		}
	}
}

