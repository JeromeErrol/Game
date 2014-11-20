using UnityEngine;
using System.Collections;

public class GameState
{
		private static GameState _instance;
		public int totalStarPieces = 5;
		public int livesRemaining;
		public float bulletTimePlayerBoost = 0.5f;
		public float bulletTimeGameSpeed = 0.5f;

		public static GameState Instance {
				get {
						if (_instance == null) {
								_instance = new GameState ();
						}
						return _instance;
				}
		}
}



