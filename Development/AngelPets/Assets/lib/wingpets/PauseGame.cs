using UnityEngine;
using System.Collections;

public class PauseGame : InstructionRunOnce
{

		public override void RunOnce ()
		{
				Fps.GameSpeed = 0;
		}
}

