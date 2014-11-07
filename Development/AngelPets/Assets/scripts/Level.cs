using UnityEngine;
using System.Collections;
using GameUtil2D;

public class Level : MonoBehaviour
{
		public static Level instance;
		public int level;
		public string sceneName;
		public string previousScene;
		public string nextScene;
		private bool lifeLost = false;

		void Start ()
		{
				gameObject.GetOrCreateComponent<LevelEffects> ();
				gameObject.GetOrCreateComponent<UserInputManager> ();
				instance = this;
				if (Player.currentLevel != level) {						
						NewLevelStarted ();
				} else {					
						LevelRepeated ();
				}
		}

		void NewGameStart ()
		{
				OnLoaded.Add (SoundLibrary.PlayNewGame);
		}

		void LevelRepeated ()
		{			// Hide title 
				FlashWhiteScreen ();
				GetComponent<FadeAGUI> ().text = "";
				OnLoaded.Add (SoundLibrary.PlayDeath);
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
				GameState.Instance.livesRemaining = GameState.Instance.totalStarPieces;
				
				GameObject.Find ("RotateMenuCog360").GetComponent<InstructionSingleInstance> ().Run ();

				if (level > 1) {
						SoundLibrary.PlayLevelCompleted ();
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
						GameState.Instance.livesRemaining--;
						lifeLost = true;
						if (GameState.Instance.livesRemaining < 1) {
								Level.RestartGame ();
						} else {
								Level.instance.Restart ();
						}
				}	
		}
	
		public void Restart ()
		{
				Application.LoadLevel (sceneName);
		}

		public void NextLevel ()
		{
				GameState.Instance.totalStarPieces++;
				Application.LoadLevel (nextScene);
		}

		public void PreviousLevel(){
			Application.LoadLevel (previousScene);
		}

		public static void RestartGame ()
		{
				Player.currentLevel = 0;			 
				Application.LoadLevel ("level1");
				
		}
}

