using UnityEngine;
using System.Collections;

public class GoToDestination : TargetedInstruction
{
	public GameObject destination;
	public float movementSpeed = 0.01f;

	public override void Run ()
	{
		target.gameObject.transform.position = Vector3.MoveTowards (target.transform.position, DestPosition, movementSpeed);
	}

	public Vector3 DestPosition{
		get{
			return destination.transform.position;
		}
	}

	public override void Begin ()
	{

	}

	public override bool IsFinished ()
	{
		return Vector3.Distance (target.transform.position, destination.transform.position) <= (movementSpeed + 0.0001f);		
	}
}

