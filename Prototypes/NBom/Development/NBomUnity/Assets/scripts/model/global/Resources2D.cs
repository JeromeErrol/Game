using UnityEngine;
using System.Collections;
using GameUtil2D;
using System;

public class Resources2D 
{
	const String assetsDir = "Assets/";
	const String texturesDir = assetsDir + "textures/";
	const string shapesDir = texturesDir + "shapes/";
	const string particlesDir = texturesDir + "particles/";

	public static Sprite Circle01 {
		get {
			return AssetUtil2D.LoadTexture (shapesDir + "circle01.png");									
		}
	}

	public static Sprite DriftLine{
		get{
			return LoadTexture(particlesDir + "driftline.png");
		}
	}

	public static Sprite LoadTexture (String filename)
	{		
		return Resources.LoadAssetAtPath<Sprite> (filename);		
	}
}

