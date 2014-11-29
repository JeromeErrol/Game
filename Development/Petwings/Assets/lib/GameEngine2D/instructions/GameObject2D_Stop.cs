using UnityEngine;
using System.Collections;

public class GameObject2D_Stop : InstructionRunOnce
{
		public GameObject2D gameObject2D;

		public override void RunOnce ()
		{
				gameObject2D.Stop ();
		}
}

