using UnityEngine;
using System.Collections;
using GameUtil2D;
using System;
using UnityEngine.Advertisements;

public class Level : MonoBehaviour
{
		public static Level instance;
		public int level;
		public string sceneName;
		public string previousScene;
		public string nextScene;
		public static int DeathCount = 0;
		public static int DeathsPerAdd = 3;

		void Start ()
		{
				this.gameObject.GetOrCreateComponent<LevelEffects> ();
				this.gameObject.GetOrCreateComponent<UserInputManager> ();
				instance = this;
				if (Player.currentLevel != level) {						
						NewLevelStarted ();
				} else {					
						LevelRepeated ();
				}

				GameObject gameObject = new GameObject ();
				gameObject.AddComponent<LevelInstructions> ();
		}

		void NewGameStart ()
		{

		}

		void LevelRepeated ()
		{			// Hide title 
				FlashWhiteScreen ();
				GetComponent<FadeAGUI> ().text = "";
				RotateStar ();
				if (Level.DeathCount % DeathsPerAdd == 0) {
						SceneAdvertisement.Show ();
				}
		}

		void RotateStar ()
		{

				//	GameObject.Find ("MenuCog").GetComponent<InstructionSingleInstance> ().Run ();
				//	GameObject.Find ("MenuStar").GetComponent<InstructionSingleInstance> ().Run ();
		}

		void FlashWhiteScreen ()
		{
				GameObject gameObject = StageUtil2D.AddGameObject (Res.Pixel, new Vector3 (0, 0, 0));
				gameObject.transform.localScale = new Vector3 (4000, 2000, 1);
				
				AlphaFade alphaFade = gameObject.AddComponent<AlphaFade> ();
				gameObject.renderer.sortingOrder = 99999;
				alphaFade.fadeSpeed = -0.1f;
				alphaFade.alpha = 1;
		}

		void NewLevelStarted ()
		{
				Player.currentLevel = level;
				GetComponent<FadeAGUI> ().text = "Level: " + level;
				GameState.Instance.livesRemaining = GameState.Instance.totalStarPieces;
				
				//GameObject.Find ("RotateMenuCog360").GetComponent<InstructionSingleInstance> ().Run ();

				if (level > 1) {

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
				Level.DeathCount++;
				
				GameObject.Find ("DIE()").GetComponent<Instructions> ().runAutomatically = true;
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

		public void PreviousLevel ()
		{
				Application.LoadLevel (previousScene);
		}

		public static void RestartGame ()
		{
				Player.currentLevel = 0;			 
				Application.LoadLevel ("level1");
				
		}
}

