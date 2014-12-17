using UnityEngine;
using System.Collections;

public class PausePlayButton : UIComponent
{	
		GameObject pauseButton;
		GameObject playButton;

		void Start ()
		{
				pauseButton = GameObject.Find ("PauseButton");
				playButton = GameObject.Find ("PlayButton");
				playButton.SetActive (false);
		}

		public override void Pressed ()
		{
				
		}

		public override void Clicked ()
		{
				GameFSM.Paused = !GameFSM.Paused;
				
				if (GameFSM.Paused) {
						pauseButton.SetActive (false);
						playButton.SetActive (true);
				} else {
						playButton.SetActive (false);
						pauseButton.SetActive (true);
				}
		}
}

