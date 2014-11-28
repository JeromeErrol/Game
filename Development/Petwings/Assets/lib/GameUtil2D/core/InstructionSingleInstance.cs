using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InstructionSingleInstance : InstructionRunOnce
{
		private string instanceName = System.Guid.NewGuid ().ToString ();
		public Instruction instruction;
		public string overwriteName;
		public bool runIfGamePaused = false;

		public override void RunOnce ()
		{
				if (overwriteName == null || overwriteName.Equals ("")) {
						if (GameObject.Find (instanceName) == null) {
								GameObject gameObject = new GameObject (instanceName);
								Instructions instructions = gameObject.AddComponent<Instructions> ();
								instructions.runIfGamePaused = runIfGamePaused;
								instructions.instructions.Add (instruction);
								instructions.runAutomatically = true;
								Destroy destroy = gameObject.AddComponent<Destroy> ();
								instructions.instructions.Add (destroy);
						}
				} else {
						GameObject existingInstance = GameObject.Find (overwriteName);
						if (existingInstance != null) {
								existingInstance.Destroy ();
						}
						GameObject gameObject = new GameObject (overwriteName);
						Instructions instructions = gameObject.AddComponent<Instructions> ();
						instructions.runIfGamePaused = runIfGamePaused;
						instructions.instructions.Add (instruction);
						instruction.Begin ();
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

