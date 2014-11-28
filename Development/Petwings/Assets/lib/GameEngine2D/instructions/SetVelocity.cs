using UnityEngine;
using System.Collections;

public class SetVelocity : InstructionRunOnce
{
		public GameObject2D gameObject2D;
		public Vector2 value;
		public bool x = true;
		public bool y = true;

		public override void RunOnce ()
		{
				if (x) {
						gameObject2D.velocity.x = value.x;
				}

				if (y) {
						gameObject2D.velocity.y = value.y;
				}
		}
}

