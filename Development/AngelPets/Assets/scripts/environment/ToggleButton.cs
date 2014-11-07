using UnityEngine;
using System.Collections;

public class ToggleButton : PlayerInteractive
{
		private bool on = false;
		public Instruction turnOnInstruction;
		public Instruction turnOffInstruction;

		public bool On {
				get {
						return on;
				}
		}

		public bool Toggle ()
		{
				on = !on;
				return on;
		}

		public override void PlayerEnter (Player player)
		{
				if (ReadyToRunInstruction) {
						if (Toggle ()) {
								turnOnInstruction.Run ();
						} else {
								turnOffInstruction.Run ();
						}
				}
		}

		private bool ReadyToRunInstruction {
				get {
						if (on) {
								return turnOnInstruction.IsFinished ();
						} else {
								return turnOffInstruction.IsFinished ();
						}
				}
		}
}


