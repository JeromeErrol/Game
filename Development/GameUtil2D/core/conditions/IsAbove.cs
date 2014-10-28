using UnityEngine;
using System.Collections;

public class IsAbove : TargetedCondition
{
	public GameObject above;

	public override bool IsMet ()
	{
		return target.transform.position.y > above.transform.position.y;
	}		
}

