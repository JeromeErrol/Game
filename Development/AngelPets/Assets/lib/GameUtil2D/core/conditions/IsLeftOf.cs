using UnityEngine;
using System.Collections;

public class IsLeftOf : TargetedCondition
{
	public GameObject left;
	
	public override bool IsMet ()
	{
		return target.transform.position.x < left.transform.position.x;
	}		
}

