using UnityEngine;
using System.Collections;

public class Eyes : CharacterPart
{
		public Sprite happyEyes;
		public Sprite blinkSprite;
		public float totalBlinkTime = 3;
		public float totalBlinkTimeRange;
		public float timeBetweenBlinks;
		public float timeBetweenBlinksRange;
		private float timeUntilNextBlink;
		private float blinkTimeRemaining;
		public Sprite currentEyes;
		
	
		// Use this for initialization
		void Start ()
		{
				gameObject.SetSprite (currentEyes);
		}
	
		public void Blink ()
		{
				blinkTimeRemaining = Mathf.Max (5, totalBlinkTime.GiveOrTake (totalBlinkTimeRange));
				gameObject.SetSprite (blinkSprite);
				timeUntilNextBlink = timeBetweenBlinks.GiveOrTake (timeBetweenBlinksRange);
		}
	
		void FixedUpdate ()
		{
				timeUntilNextBlink -= gameObject.GetRelativeSpeed ();
				if (timeUntilNextBlink <= 0) {
						Blink ();
				}
		
				if (blinkTimeRemaining > 0) {
						blinkTimeRemaining--;
						if (blinkTimeRemaining <= 0) {
								gameObject.SetSprite (currentEyes);
						}
				}
		}
}

