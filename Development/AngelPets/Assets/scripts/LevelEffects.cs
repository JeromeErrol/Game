using UnityEngine;
using System.Collections;

public class LevelEffects : MonoBehaviour
{
		void Start ()
		{		
				FadeStar ();
		}

		void FadeStar ()
		{
				
		float livesLost = GameState.Instance.totalStarPieces - GameState.Instance.livesRemaining;
				GameObject sta = GameObject.Find ("MenuStar");
				float angle = 71f;
		
				for (int i = 1; i <= livesLost; i++) {
						if (i != 1) {
								sta.RotateBy (angle);
						}
						GameObject star = GameObject.Find ("star" + i);
						star.SetAlpha (0.2f);
						if (i == livesLost) {
								star.SetAlpha (1f);

								GameObject fadeToNothing = new GameObject ();
								InstructionSingleInstance instance = fadeToNothing.AddComponent<InstructionSingleInstance> ();
								For forLoop = fadeToNothing.AddComponent<For> ();
								forLoop.numberOfFrames = 75;
								Fade fade = fadeToNothing.AddComponent<Fade> ();
								fade.amount = -0.01f;
								forLoop.instructions.Add (fade);
								fade.target = star;
								instance.instruction = forLoop;
								instance.Run ();
						}
				}
		}

		void FadeStars(int visibleStarPieces, int faded){

		}
}

