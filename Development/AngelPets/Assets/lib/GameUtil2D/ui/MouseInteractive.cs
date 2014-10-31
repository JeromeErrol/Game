using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Collider2D))]
public class MouseInteractive : MonoBehaviour
{
		public Instruction instruction;

		void OnMouseDown ()
		{
				if (instruction) {
						instruction.Run ();
				}
		}
}

