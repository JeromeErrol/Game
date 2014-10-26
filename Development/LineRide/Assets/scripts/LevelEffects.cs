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
				float livesLost = 5 - Level.livesRemaining;
		
				GameObject sta = GameObject.Find ("MenuStar");
				float angle = 71f;
		
				for (int i = 1; i <= livesLost; i++) {
						if (i != 1) {
								sta.RotateBy (angle);
						}
						GameObject star = GameObject.Find ("star" + i);
						star.SetAlpha (0.2f);
				}
		}
}

