using UnityEngine;
using System.Collections;
using System;

public abstract class GameAction : MonoBehaviour
{
		public delegate void GameActionEvent (GameAction sender);

		public event GameActionEvent running;
		public event GameActionEvent finished;
	

		public void RunAction ()
		{
				running (this);
				if (Run () == false) {
						finished (this);
				};
		}

		public virtual void Reset(){

		}

		/// <summary>
		/// Performs some action
		/// </summary>
		/// <returns><c>true</c>, if run was _ed, <c>false</c> otherwise.</returns>
		protected abstract bool Run ();

}

