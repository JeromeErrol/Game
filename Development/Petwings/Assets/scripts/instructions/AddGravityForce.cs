using UnityEngine;
using System.Collections;

public class AddGravityForce : InstructionRunOnce
{
		public GameObject2D gameObject2D;

		public override void RunOnce ()
		{
				gameObject2D.gameObject.GetOrCreateComponent<Force2D> ().value.y = -0.005f;
		}
}

