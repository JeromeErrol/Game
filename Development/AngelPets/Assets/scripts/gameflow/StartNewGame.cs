using UnityEngine;
using System.Collections;

public class StartNewGame : InstructionRunOnce
{

		public override void RunOnce ()
		{
				Level.RestartGame ();
		}
}

