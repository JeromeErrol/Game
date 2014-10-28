using UnityEngine;
using System.Collections;

public class BehaviorInteractive : MonoBehaviour
{
		private bool sameFrame = false;
		public GameObject interactWith;
		public Instruction enterInstruction;
		public Instruction stayInstruction;
		public Instruction leaveInstruction;
		public bool newSingleInstance = false;
	
		void Update ()
		{
				sameFrame = false;
		}
	
		void OnTriggerEnter2D (Collider2D collider2D)
		{		
				if (enterInstruction != null) {
						if (!sameFrame) {
								sameFrame = true;
								if (collider2D.gameObject == interactWith) {
										if (newSingleInstance == false) {
												enterInstruction.Run ();
										} else {
												GameObject gameObject = new GameObject ("temp"); // Objects named 'temp' get garbage collected at the end of the frame. 
												InstructionSingleInstance instance = gameObject.AddComponent<InstructionSingleInstance> ();
												instance.instruction = enterInstruction;
												instance.RunOnce ();
												gameObject.Destroy ();
										}
								}
						}
				}				
		}
	
		void OnTriggerStay2D (Collider2D collider2D)
		{
				if (stayInstruction != null) {
						if (collider2D.gameObject == interactWith) {
								if (newSingleInstance == false) {
										stayInstruction.Run ();
								} else {
										GameObject gameObject = new GameObject ("temp"); // Objects named 'temp' get garbage collected at the end of the frame. 
										InstructionSingleInstance instance = gameObject.AddComponent<InstructionSingleInstance> ();
										instance.instruction = stayInstruction;
										instance.RunOnce ();
										gameObject.Destroy ();
								}
						}
				}
		}
	
		void OnTriggerExit2D (Collider2D collider2D)
		{
				if (leaveInstruction != null) {
						if (collider2D.gameObject == interactWith) {
								leaveInstruction.Run ();
						} else {
								GameObject gameObject = new GameObject ("temp"); // Objects named 'temp' get garbage collected at the end of the frame. 
								InstructionSingleInstance instance = gameObject.AddComponent<InstructionSingleInstance> ();
								instance.instruction = leaveInstruction;
								instance.RunOnce ();
								gameObject.Destroy ();
						}
				}
		}
}

