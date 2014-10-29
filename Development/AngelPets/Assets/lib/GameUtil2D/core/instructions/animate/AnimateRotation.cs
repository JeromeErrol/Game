using UnityEngine;
using System.Collections;

public class AnimateRotation : Animate
{
		public override void UpdateValue (float velocity)
		{
				Target.gameObject.RotateBy (velocity);
		}
}

