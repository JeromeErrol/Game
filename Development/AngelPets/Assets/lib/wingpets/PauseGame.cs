using UnityEngine;
using System.Collections;

public class PauseGame : InstructionRunOnce
{

		public override void RunOnce ()
		{
				Game.Instance.Paused = true;
		}
}

