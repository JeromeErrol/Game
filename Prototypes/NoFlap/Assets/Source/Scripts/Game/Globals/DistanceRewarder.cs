using UnityEngine;
using System.Collections;

public class DistanceRewarder : MonoBehaviour
{
		private static DistanceRewarder instance;
		int nextPass = 0;
		int distanceBetweenPasses = 1;
		int bonusPerPass = 5;

		void Awake ()
		{
				instance = this;
		}

		void Update ()
		{
				CheckIfPassedX ();
		}

		void CheckIfPassedX ()
		{
				float playerX = Player.instance.transform.position.x;
				if (playerX > nextPass) {
						XPassed ();
				}
		}

		private void XPassed ()
		{
				nextPass += distanceBetweenPasses;
				Score.Add (bonusPerPass);
		}
}

