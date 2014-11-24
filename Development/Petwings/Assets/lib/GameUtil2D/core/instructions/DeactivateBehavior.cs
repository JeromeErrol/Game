using UnityEngine;
using System.Collections;

public class DeactivateBehavior : InstructionRunOnce
{
		public MonoBehaviour behavior;

		public override void RunOnce ()
		{
			behavior.enabled = false;
			print ("Hello");
		}
	
}

