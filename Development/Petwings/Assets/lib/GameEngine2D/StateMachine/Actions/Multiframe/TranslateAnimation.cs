using UnityEngine;
using System.Collections;

public class TranslateAnimation : MultiFrameAction
{
		public Vector2 translation;
		public int numberOfFrames;
		private int frameNumber;
		public Transform target;

		public override void Interrupted ()
		{
				
		}

		public override void Run ()
		{
				Vector3 pos = target.position;
				pos.x += translation.x;
				pos.y += translation.y;
				target.position = pos;
				frameNumber++;
		}

		public override void Start ()
		{
				frameNumber = 0;
		}

		public override bool HasFinished {
				get {
						return frameNumber >= numberOfFrames;
				}
		}
}

