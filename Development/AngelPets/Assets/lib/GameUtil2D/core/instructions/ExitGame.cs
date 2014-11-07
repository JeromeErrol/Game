using UnityEngine;
using System.Collections;

public class ExitGame : InstructionRunOnce
{

		public override void RunOnce ()
		{
				Application.Quit ();
		}
}

