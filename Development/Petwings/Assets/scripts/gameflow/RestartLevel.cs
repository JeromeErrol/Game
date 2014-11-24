using UnityEngine;
using System.Collections;

public class RestartLevel : InstructionRunOnce
{
		public override void RunOnce ()
		{
				Level.instance.Restart ();
		}
}

