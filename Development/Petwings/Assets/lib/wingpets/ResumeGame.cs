using UnityEngine;
using System.Collections;

public class ResumeGame : InstructionRunOnce
{
		public override void RunOnce ()
		{
				Game.Instance.Paused = false;
		}
}

