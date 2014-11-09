using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InstructionSingleInstance : InstructionRunOnce
{
		private string instanceName = System.Guid.NewGuid ().ToString ();
		public Instruction instruction;

		public override void RunOnce ()
		{
				if (GameObject.Find (instanceName) == null) {
						GameObject gameObject = new GameObject (instanceName);
						Instructions instructions = gameObject.AddComponent<Instructions> ();
						instructions.instructions.Add (instruction);
						instructions.runAutomatically = true;
						Destroy destroy = gameObject.AddComponent<Destroy> ();
						instructions.instructions.Add (destroy);
				}
		}

		public static void RunInInstance (Instruction instruction)
		{
				GameObject gameObject = new GameObject ("temp"); // Objects named 'temp' get garbage collected at the end of the frame. 
				InstructionSingleInstance instance = gameObject.AddComponent<InstructionSingleInstance> ();
				instance.instruction = instruction;
				instance.RunOnce ();
				gameObject.Destroy ();
		}
}

