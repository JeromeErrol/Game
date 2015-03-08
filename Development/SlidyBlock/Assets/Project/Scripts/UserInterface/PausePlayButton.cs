using UnityEngine;
using System.Collections;

public class PausePlayButton : UIComponent
{	
		GameObject pauseButton;
		GameObject playButton;
		GameObject exitButton;

		void Start ()
		{
				pauseButton = GameObject.Find ("PauseButton");
				playButton = GameObject.Find ("PlayButton");
				exitButton = GameObject.Find ("ExitButton");
				CloseMenu ();
		}

		public override void Pressed ()
		{
				ToggleMenu ();
		}

		public override void Clicked ()
		{
				ToggleMenu ();		
		}

		private void ToggleMenu ()
		{
				GameFSM.Paused = !GameFSM.Paused;
		
				if (GameFSM.Paused) {
						OpenMenu ();
				} else {
						CloseMenu ();
				}
		}

		private void CloseMenu ()
		{
				pauseButton.SetActive (true);
				exitButton.SetActive (false);
				playButton.SetActive (false);
		}

		private void OpenMenu ()
		{
				pauseButton.SetActive (false);
				exitButton.SetActive (true);
				playButton.SetActive (true);
		}
}

