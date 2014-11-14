using UnityEngine;
using System.Collections;

public class AddComponentGravity : TargetedInstruction
{
		public override void Begin ()
		{

		}

		public override void Run ()
		{
				Target.GetOrCreateComponent<Gravity> ();
		}

		public override bool IsFinished ()
		{
				return Target.GetComponent<Gravity> () == null;
		}
}

