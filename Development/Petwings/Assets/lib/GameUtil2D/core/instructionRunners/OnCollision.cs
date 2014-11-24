using UnityEngine;
using System.Collections;

public class OnCollision : MonoBehaviour
{
		public Collider2D with;
		public Instruction instruction;
		private bool sameFrame;

		void FixedUpdate ()
		{
				sameFrame = false;
		}

		void OnTriggerEnter2D (Collider2D collider2D)
		{		
				if (collider2D == with && sameFrame == false) {
						sameFrame = true;
						instruction.Run ();
				}				
		}
}

