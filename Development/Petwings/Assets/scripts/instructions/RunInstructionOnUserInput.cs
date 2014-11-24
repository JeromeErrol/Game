using UnityEngine;
using System.Collections;

public class RunInstructionOnUserInput : UserInteractive
{
		public Instruction instruction;
		private bool pressed = false;

		public override void Pressed ()
		{
				if (!pressed) {
						pressed = true;
						instruction.Run ();
				} 
		}

		void Update ()
		{
				pressed = false;
		}

		
}

