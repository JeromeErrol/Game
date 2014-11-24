using UnityEngine;
using System.Collections;

public class SetRotation : Setter
{
	public float rotation;

	public override void Set ()
	{
		Quaternion q = Target.transform.rotation;
		q.z = rotation;
		Target.transform.rotation = q;
	}
		
}

