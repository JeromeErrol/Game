using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour
{
		public static Level instance;
		public int level;

		void Start ()
		{
				instance = this;
				Screen.orientation = ScreenOrientation.LandscapeLeft;
		}

		void Update ()
		{
				instance = this;
		}

		public static bool Paused {
				get {
						return Time.timeScale == 0;
				}set {
					if(value){
							Time.timeScale = 0;
						}else{
							Time.timeScale = 1;
						}
				}
						
			
		}

		public string LevelName {
				get {
						return "level" + level;
				}
		}

		public void LoseLife ()
		{
				Player.livesRemaining--;
				if (Player.livesRemaining < 0) {
						Level.RestartGame ();
				} else {
						Level.instance.Restart ();
				}			
		}
	
		public void Restart ()
		{
				Application.LoadLevel ("level" + level);
		}

		public void NextLevel ()
		{
				Application.LoadLevel ("level" + (level + 1));
		}

		public static void RestartGame ()
		{
				Application.LoadLevel ("level1");
				Player.livesRemaining = Player.StartingLives;
		}
}

