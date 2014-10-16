using UnityEngine;
using System.Collections;

public class SetPosition : Setter
{
	public GameObject destinationPosition;


	public override void Set ()
	{
		Target.transform.position = destinationPosition.transform.position;
	}
}

