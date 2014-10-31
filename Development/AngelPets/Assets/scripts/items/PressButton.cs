using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PressButton : PlayerInteractive
{
		public bool runInstructionsInNewInstance = false;
		public List<Instruction> instructions = new List<Instruction> ();
	
		public override void PlayerEnter (Player player)
		{
				if (runInstructionsInNewInstance) {
						for (int i = 0; i < this.instructions.Count; i++) {			
								GameObject gameObject = new GameObject ("temp"); // Objects named 'temp' get garbage collected at the end of the frame. 
								InstructionSingleInstance instance = gameObject.AddComponent<InstructionSingleInstance> ();
								instance.instruction = instructions [i];
								instance.RunOnce ();
								gameObject.Destroy ();
						}
				} else {
						for (int i = 0; i < this.instructions.Count; i++) {
								instructions [i].Run ();


						}
				}
		}
}
