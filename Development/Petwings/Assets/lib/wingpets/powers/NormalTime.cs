using UnityEngine;
using System.Collections;

public class NormalTime : InstructionRunOnce
{
		public override void RunOnce ()
		{
				Game.Instance.Speed ().value = 1.0f;
		}
}

