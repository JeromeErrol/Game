using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Cat : MonoBehaviour
{
		public List<Sprite> frames = new List<Sprite> ();
		private int currentIndex;
		private int currentDirection;
		public int timePerFrame = 5;
		private int nextFrame;

		void Start ()
		{
				currentIndex = 0;
				currentDirection = -1;
				nextFrame = timePerFrame;
		}
	
		// Update is called once per frame
		void Update ()
		{		
				gameObject.SetSprite (CurrentSprite);
				nextFrame--;
				if (nextFrame <= 0) {
						nextFrame = timePerFrame;
						if (currentIndex >= frames.Count - 1 || currentIndex <= 0) {
								currentDirection = -currentDirection;
						}
						currentIndex += currentDirection;
				}
		}
	
		public Sprite CurrentSprite {
				get {
						return frames [currentIndex];
				}
		}
}

