using UnityEngine;
using System.Collections;

public class InstructionSingleInstance : InstructionRunOnce
{
		private string instanceName = System.Guid.NewGuid().ToString();
		public Instruction instruction;

		public override void RunOnce ()
		{
			if (GameObject.Find (instanceName) == null) {
				GameObject gameObject = new GameObject(instanceName);
				Instructions instructions = gameObject.AddComponent<Instructions>();
				instructions.instructions.Add(instruction);
				instructions.runAutomatically = true;
				Destroy destroy = gameObject.AddComponent<Destroy>();
				instructions.instructions.Add(destroy);
			}
		}
}
