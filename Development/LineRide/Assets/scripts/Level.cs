using UnityEngine;
using System.Collections;
using GameUtil2D;

public class Level : MonoBehaviour
{
		public static Level instance;
		public int level;
		public static int livesRemaining;
		private bool lifeLost = false;

		void Start ()
		{
				gameObject.GetOrCreateComponent<LevelEffects> ();
				instance = this;
				Screen.orientation = ScreenOrientation.LandscapeLeft;
				if (Player.currentLevel != level) {						
						NewLevelStarted ();
				} else {					
						LevelRepeated ();
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
				GameObject.Find ("MenuCog").GetComponent<InstructionSingleInstance> ().Run ();
				GameObject.Find ("MenuStar").GetComponent<InstructionSingleInstance> ().Run ();
		}

		void FlashWhiteScreen ()
		{
				GameObject gameObject = StageUtil2D.AddGameObject (Res.Pixel, new Vector3 (0, 0, 0));
				gameObject.transform.localScale = new Vector3 (3100, 1750, 1);

				AlphaFade alphaFade = gameObject.AddComponent<AlphaFade> ();
				alphaFade.fadeSpeed = -0.1f;
				alphaFade.alpha = 1;
		}

		void NewLevelStarted ()
		{
				Player.currentLevel = level;
				GetComponent<FadeAGUI> ().text = "Level: " + level;
				Level.livesRemaining = 5;
				
				GameObject.Find ("RotateMenuCog360").GetComponent<InstructionSingleInstance> ().Run ();

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
				if (!lifeLost) {
						lifeLost = true;
						livesRemaining--;
						lifeLost = true;
						if (livesRemaining < 1) {
								Level.RestartGame ();
						} else {
								Level.instance.Restart ();
						}
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

