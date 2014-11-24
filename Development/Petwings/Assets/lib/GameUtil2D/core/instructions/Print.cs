using UnityEngine;
using System.Collections;

public class Print : InstructionRunOnce
{
		public string text;

		public override void RunOnce ()
		{
				print (text);
		}
}

