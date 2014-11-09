using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpriteSheet : MonoBehaviour
{
	public List<Sprite> frames = new List<Sprite> ();
	public int timePerFrame;
	public bool reverseOnFinish = true;
	private int currentIndex;
	private int currentDirection;
	private float nextFrame;
	
	void Start ()
	{
		currentIndex = 0;
		currentDirection = -1;
		nextFrame = timePerFrame;
	}
	
	void Update ()
	{		
		gameObject.SetSprite (CurrentSprite);
		nextFrame-= Fps.Correct;
		if (nextFrame <= 0) {
			nextFrame = timePerFrame;
			if (reverseOnFinish && currentIndex >= frames.Count - 1 || currentIndex <= 0) {
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

