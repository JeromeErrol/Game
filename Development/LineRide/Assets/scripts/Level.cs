using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour
{
		public static Level instance;
		public int level;
		public int startingLives;
		private static int livesRemaining;
		public AudioClip deathSoundEffect;
		public AudioClip levelCompletedSound;

		void Start ()
		{
				instance = this;
				Screen.orientation = ScreenOrientation.LandscapeLeft;
				
				if (Player.currentLevel != level) {						
						NewLevelStarted ();
				} else {					
						LevelRepeated ();
				}
				
		}

		void LevelRepeated ()
		{			// Hide title 
				GetComponent<FadeAGUI> ().text = "Lives: " + livesRemaining;
				audio.PlayOneShot (deathSoundEffect);
		}

		void NewLevelStarted ()
		{
				Player.currentLevel = level;
				livesRemaining = startingLives;
				GetComponent<FadeAGUI> ().text += " Lives: " + livesRemaining;
				

				if (level > 1) {
						audio.PlayOneShot (levelCompletedSound);
				}
	}
	
		void Update ()
		{
				instance = this;

				if (Input.GetKeyDown (KeyCode.T)) {
						audio.PlayOneShot (deathSoundEffect);
				}
		}

		public static bool Paused {
				get {
						return Time.timeScale == 0;
				}set {
						if (value) {
								Time.timeScale = 0;
						} else {
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
			audio.PlayOneShot (deathSoundEffect);
			livesRemaining--;
				if (livesRemaining < 0) {
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
				Player.currentLevel = 0;			 
				Application.LoadLevel ("level1");
				
		}
}

