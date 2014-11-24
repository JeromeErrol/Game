using UnityEngine;
using System.Collections;

public class Lightening : MonoBehaviour
{
		public float timeBetweenFlashes;
		public float timeBetweenFlashesRange;
		private float timeUntilNextFlash;



		void Start ()
		{
		timeUntilNextFlash = timeBetweenFlashes.GiveOrTake (timeBetweenFlashesRange);
		}
	
		
		void Update ()
		{
				timeUntilNextFlash--;
				if (timeUntilNextFlash <= 0) {
						timeUntilNextFlash = timeBetweenFlashes.GiveOrTake (timeBetweenFlashesRange);
						gameObject.SetAlpha(0);
				} else {
						gameObject.ModifyAlpha(0.01f);
				}
		}
}

