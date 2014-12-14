using UnityEngine;
using System.Collections;
using UnityUtil.Extensions;

public class Eyes : MonoBehaviour
{
		public float totalBlinkTime = 3;
		public float totalBlinkTimeRange;
		public float timeBetweenBlinks;
		public float timeBetweenBlinksRange;
		private float timeUntilNextBlink;
		private float blinkTimeRemaining;
		public Sprite openEyes;
		public Sprite closedEyes;
		
	
		public void Blink ()
		{
				Close ();
				blinkTimeRemaining = Mathf.Max (5, totalBlinkTime.GiveOrTake (totalBlinkTimeRange));
		}

		public void Close ()
		{
				gameObject.SetSprite (closedEyes);
		}

		public void Open ()
		{
				gameObject.SetSprite (openEyes);
		}
	
		void FixedUpdate ()
		{
				float gameTime = 60 * Time.deltaTime;
				if (gameObject.GetSprite() == openEyes) {
						timeUntilNextBlink -= gameTime;
						if (timeUntilNextBlink <= 0) {
								Blink ();
						}
				} else {
						if (blinkTimeRemaining > 0) {
								blinkTimeRemaining -= gameTime;
						} else {
								timeUntilNextBlink = timeBetweenBlinks.GiveOrTake (timeBetweenBlinksRange);
								Open ();
						}
				}
		}
}

