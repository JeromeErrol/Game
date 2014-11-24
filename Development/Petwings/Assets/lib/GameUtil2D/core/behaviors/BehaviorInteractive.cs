using UnityEngine;
using System.Collections;

public class BehaviorInteractive : MonoBehaviour
{
		private bool sameFrame = false;
		public GameObject interactWith;
		public Instruction enterInstruction;
		public Instruction hoverInstruction;
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
												InstructionSingleInstance.RunInInstance (enterInstruction);
										}
								}
						}
				}				
		}
	
		void OnTriggerStay2D (Collider2D collider2D)
		{
				if (hoverInstruction != null) {
						if (collider2D.gameObject == interactWith) {
								if (newSingleInstance == false) {
										hoverInstruction.Run ();
								} else {
										InstructionSingleInstance.RunInInstance (hoverInstruction);
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
								InstructionSingleInstance.RunInInstance (leaveInstruction);
						}
				}
		}
}

