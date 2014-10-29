using UnityEngine;
using System.Collections;

public class IsBelow : TargetedCondition
{
	public GameObject below;
	
	public override bool IsMet ()
	{
		return target.transform.position.y < below.transform.position.y;
	}		
}

