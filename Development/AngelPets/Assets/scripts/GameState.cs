using UnityEngine;
using System.Collections;

public class GameState
{
		public string[] SCENES = {
			"level0",
			"level1",
			"level2",
			"level3",
			"level4",
			"level5",
			"level6",
			"level7",
			"level8",
			"level9",
			"level10",
			"level11",
			"level12",
			"level13"
	};
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



