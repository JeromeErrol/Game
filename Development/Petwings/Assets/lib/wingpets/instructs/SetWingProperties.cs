using UnityEngine;
using System.Collections;

public class SetWingProperties : InstructionRunOnce
{
		public Wings wings;
		public float averageHeight;
		public float peakHeight;
		public float speed;

		public override void RunOnce ()
		{
				wings.averageHeight = averageHeight;
				wings.peakHeight = peakHeight;
				wings.speed = speed;
		}
}

