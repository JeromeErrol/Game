using UnityEngine;
using System.Collections;

public class AnimateY : Animate
{
	public override void UpdateValue (float velocity)
	{
		Vector3 pos = Target.gameObject.transform.position;
		pos.y += velocity;
		Target.gameObject.transform.position = pos;
	}
}

