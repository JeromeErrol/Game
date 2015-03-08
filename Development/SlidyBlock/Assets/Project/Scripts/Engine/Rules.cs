using UnityEngine;
using System.Collections;

public class Rules : MonoBehaviour
{	
		private float screenBound = 9.3f;

		void FixedUpdate ()
		{
				PreventPlayerFromPassingLeftScreenBound ();
            
				if (PlayerHasPassedTheFinishLine ()) {
						if (PlayerHasMetVictoryConditions ()) {
								
								GameFSM.LoadNextLevel ();
						} else {
								MovePlayerToFinishLine ();
						}
				}
		}

		bool PlayerHasMetVictoryConditions ()
		{
				return PlayerHasPassedTheFinishLine () && NoKeysAreRemaining ();
		}

		bool PlayerHasPassedTheFinishLine ()
		{
				return Player.PositionX > screenBound;
		}

		bool NoKeysAreRemaining ()
		{
				return GameObject.FindObjectsOfType<Key> ().Length == 0;
		}
	
		private void PreventPlayerFromPassingLeftScreenBound ()
		{
				if (Player.PositionX < -screenBound) {
						Player.PositionX = -screenBound;
				}
		}

		private void MovePlayerToFinishLine ()
		{
				Player.PositionX = screenBound;
		}
}

