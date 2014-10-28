using UnityEngine;
using System.Collections;

public class AnimateX : Animate
{
	public override void UpdateValue (float velocity)
	{
		Vector3 pos = Target.gameObject.transform.position;
		pos.x += velocity;
		Target.gameObject.transform.position = pos;
	}
}

