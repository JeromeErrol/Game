using UnityEngine;
using System.Collections;

public class IsRightOf : TargetedCondition
{
	public GameObject right;
	
	public override bool IsMet ()
	{
		return target.transform.position.x > right.transform.position.x;
	}		
}

