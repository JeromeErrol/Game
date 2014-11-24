using UnityEngine;
using System.Collections;

public class RunContinous : MonoBehaviour
{
		public Instruction instruction;

		void FixedUpdate ()
		{
				instruction.Run ();
		}
}

