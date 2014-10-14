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

		public string LevelName {
				get {
						return "level" + level;
				}
		}

		public void LoseLife ()
		{
				Player.livesRemaining--;
				if (Player.livesRemaining < 0) {
						Level.instance.RestartGame ();
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

		public void RestartGame ()
		{
				Application.LoadLevel ("level1");
				Player.livesRemaining = Player.StartingLives;
		}
}

