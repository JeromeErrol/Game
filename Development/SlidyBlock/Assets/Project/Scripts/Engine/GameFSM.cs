using UnityEngine;
using System.Collections;

[RequireComponent (typeof(PlayMakerFSM))]
public class GameFSM : MonoBehaviour
{
		public static GameFSM instance;
		private PlayMakerFSM fsm;

		void Awake ()
		{
				instance = this;
				fsm = GetComponent<PlayMakerFSM> ();
		}

		public static bool Paused {
				get {
						return instance.fsm.ActiveStateName == "Paused";
				}set {
						if (value) {
								instance.fsm.SendEvent ("Pause");
						} else {
								instance.fsm.SendEvent ("Resume");
						}
				}
		}

		public static void LoadNextLevel ()
		{
				EventHistory.Add (GameEvent.LevelCompleted);
				instance.fsm.SendEvent ("LoadNextLevel");
		}

		public static void RestartLevel ()
		{
				EventHistory.Add (GameEvent.Died);
				instance.fsm.SendEvent ("Restart");
		}

		public static void Exit ()
		{
				instance.fsm.SendEvent ("Exit");
		}
}
