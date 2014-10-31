using UnityEngine;
using System.Collections;

public class GameState
{
		private static GameState _instance;
		public int totalStarPieces = 5;
		public int livesRemaining;
		
	
		private GameState ()
		{

		}

		public static GameState Instance {
				get {
						if (_instance == null) {
								_instance = new GameState ();
						}
						return _instance;
				}
		}
}



