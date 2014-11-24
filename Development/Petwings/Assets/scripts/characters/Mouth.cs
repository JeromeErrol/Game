using UnityEngine;
using System.Collections;

public class Mouth : CharacterPart
{
	public Sprite openMouthSprite;
	public Sprite smilingSprite;

	public void Smile(){
		gameObject.SetSprite (smilingSprite);
	}

	public void OpenMouth(){
		gameObject.SetSprite (openMouthSprite);
	}
		
}

