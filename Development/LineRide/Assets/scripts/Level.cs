using UnityEngine;
using System.Collections;
using GameUtil2D;

public class Level : MonoBehaviour
{
		public static Level instance;
		public int level;
		//public int startingLives;
		private static int livesRemaining;
		public Color backgroundColor;

		void Start ()
		{
				instance = this;
				Screen.orientation = ScreenOrientation.LandscapeLeft;
				if (Player.currentLevel != level) {						
						NewLevelStarted ();
				} else {					
						LevelRepeated ();
				}	
				FadeStar ();
		}

		void FadeStar ()
		{
				float livesLost = 5 - livesRemaining;

				GameObject sta = GameObject.Find ("StarLives");
				float angle = 71f;

				//sta.transform.Rotate (livesLost * angle);

				for (int i = 1; i <= livesLost; i++) {
						if (i != 1) {
								sta.RotateBy (angle);
						}
						GameObject star = GameObject.Find ("star" + i);
						star.SetAlpha (0.2f);
				}
		}

		void NewGameStart ()
		{
				audio.PlayOneShot (Res.StartNewGameSound);
		}

		void LevelRepeated ()
		{			// Hide title 
				FlashWhiteScreen ();
				GetComponent<FadeAGUI> ().text = "";
				audio.PlayOneShot (Res.LoseLifeSound);

				RotateStar ();
		}

		void RotateStar ()
		{
				GameObject menuCog = GameObject.Find ("MenuCog");
				InstructionSingleInstance instance = menuCog.GetComponent<InstructionSingleInstance> ();
				instance.Run ();
		}

		void FlashWhiteScreen ()
		{
				GameObject gameObject = StageUtil2D.AddGameObject (Res.Pixel, new Vector3 (14.91f, 0, 0));
				gameObject.transform.localScale = new Vector3 (3100, 1750, 1);

				AlphaFade alphaFade = gameObject.AddComponent<AlphaFade> ();
				alphaFade.fadeSpeed = -0.1f;
				alphaFade.alpha = 1;
		}

		void NewLevelStarted ()
		{
				Player.currentLevel = level;
				livesRemaining = 5;
				

				if (level > 1) {
						audio.PlayOneShot (Res.LevelCompletedSound);
				} else {
						NewGameStart ();
				}
		}
	
		void Update ()
		{
				instance = this;
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
				livesRemaining--;
				if (livesRemaining < 1) {
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

