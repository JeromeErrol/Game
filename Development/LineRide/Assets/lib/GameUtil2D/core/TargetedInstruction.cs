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
}

