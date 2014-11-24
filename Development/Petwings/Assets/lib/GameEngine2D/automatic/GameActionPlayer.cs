using UnityEngine;
using System.Collections;

public class GameActionPlayer : GameAction
{
		public bool playing;
		public GameAction gameAction;
		public bool runOnce = false;
		private bool hasRun = false;
	
		void Update ()
		{
				if (playing) {
						gameAction.RunAction ();
				}
		}

		protected override bool Run ()
		{
				return false;
		}
}

