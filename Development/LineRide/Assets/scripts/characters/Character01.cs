using UnityEngine;
using System.Collections;

public class Character01 : MonoBehaviour
{	
		public Sprite passiveSprite;
		public Sprite blinkSprite;
		public float totalBlinkTime = 3;
		public float totalBlinkTimeRange;
		public float timeBetweenBlinks;
		public float timeBetweenBlinksRange;
		private float timeUntilNextBlink;
		private float blinkTimeRemaining;
		

		void Start ()
		{
				SetShakeAmount ();
		}

		void SetShakeAmount ()
		{
				Shake shake = gameObject.GetOrCreateComponent<Shake> ();
		
				switch (Level.livesRemaining) {
			
				case 2:
						shake.intensity = new Vector3 (0.0025f, 0.002f);
						return;
				case 1:
						shake.intensity = new Vector3 (0.004f, 0.004f);
						return;
				default:
						return;			
				}		
		}
	
		public void Blink ()
		{
				blinkTimeRemaining = Mathf.Max (5, totalBlinkTime.GiveOrTake (totalBlinkTimeRange));
				gameObject.SetSprite (blinkSprite);
				timeUntilNextBlink = timeBetweenBlinks.GiveOrTake (timeBetweenBlinksRange);
		}

		void Update ()
		{
				timeUntilNextBlink--;
				if (timeUntilNextBlink <= 0) {
						Blink ();
				}

				if (blinkTimeRemaining > 0) {
						blinkTimeRemaining--;
						if (blinkTimeRemaining <= 0) {
								gameObject.SetSprite (passiveSprite);
						}
				}
		}

		
}

