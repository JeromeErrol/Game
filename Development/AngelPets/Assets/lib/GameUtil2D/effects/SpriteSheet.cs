using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpriteSheet : MonoBehaviour
{
		public List<Sprite> frames = new List<Sprite> ();
		public float timePerFrame;
		public bool reverseOnFinish = true;
		private int currentDirection;
		private float maxTime;
		private float currentTime;

		void Start ()
		{
				currentDirection = -1;
				currentTime = timePerFrame;
				maxTime = timePerFrame * frames.Count;
		}
	
		void Update ()
		{		
				
				gameObject.SetSprite (CurrentSprite);
				float speed = gameObject.GetRelativeSpeed ();
				currentTime += (speed * currentDirection);
				
				if (currentTime > maxTime || currentTime < 0) {
						if (reverseOnFinish) {
								currentDirection = -currentDirection;
								currentTime += (speed * currentDirection);
						} else {
								currentTime = 0;
						}
				}
		}

		public void SetTimePerFrame (float value)
		{
				float difference = value / timePerFrame;
				timePerFrame = value;
				maxTime = timePerFrame * frames.Count;
				currentTime *= difference;
		}
	
		public Sprite CurrentSprite {
				get {
						return frames [(int)(currentTime / timePerFrame)];
				}
		}
}

