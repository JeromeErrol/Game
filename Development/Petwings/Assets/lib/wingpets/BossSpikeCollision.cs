using UnityEngine;
using System.Collections;

public class BossSpikeCollision : InstructionRunOnce
{
		public Transform enemy;
		public float shrinkSize;
		public int lives = 3;
		private int hitCount = 0;
		public Instruction instructionOnDeath;

		public override void RunOnce ()
		{
				hitCount++;
				if (hitCount == lives) {
						instructionOnDeath.Run ();
				} else {
						enemy.localScale *= shrinkSize;
				}
		}
}

