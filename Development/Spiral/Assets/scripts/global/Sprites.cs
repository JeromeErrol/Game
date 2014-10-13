using UnityEngine;
using System.Collections;
using GameUtil2D;

public class Sprites 
{
	public static Sprite circle;	
	public static Sprite circle_128x128B;	
	public static Sprite square_128x128;
	public static Sprite square_128x128B;
	public static Sprite arrow_128;

	public static Sprite banana_x1;
	public static Sprite cherry_x1;

	public static void LoadSprites(){
		circle = Resources.LoadAssetAtPath<Sprite> ("Assets/textures/shapes/circle.png");
		square_128x128 = Resources.LoadAssetAtPath<Sprite> ("Assets/textures/shapes/square_128x128.png");
		square_128x128B = Resources.LoadAssetAtPath<Sprite> ("Assets/textures/shapes/square_128x128B.png");
		arrow_128 = Resources.LoadAssetAtPath<Sprite> ("Assets/textures/shapes/arrow_128.png");
		circle_128x128B = Resources.LoadAssetAtPath<Sprite> ("Assets/textures/shapes/circle_128x128B.png");
		banana_x1 = Resources.LoadAssetAtPath<Sprite> ("Assets/textures/items/banana_x1.png");
		cherry_x1 = Resources.LoadAssetAtPath<Sprite> ("Assets/textures/items/cherry_x1.png");
	}		
}

