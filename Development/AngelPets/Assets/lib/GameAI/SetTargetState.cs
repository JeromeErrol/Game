using UnityEngine;
using System.Collections;

public class SetTargetState : InstructionRunOnce
{
		public StateManager stateManager;
		public TargetState newTargetState;

		public override void RunOnce ()
		{
				stateManager.targetState = newTargetState;
		}
		
}

