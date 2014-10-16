using UnityEngine;
using System.Collections;
using System;

public class Res
{
	private const String resources_dir = "Assets/resources/";
	private const String texture_dir = resources_dir + "textures/";
	private const String environment_dir = Res.texture_dir + "environment/";

	public static Sprite raindrop = LoadEnvironment("raindrop.png");
	//public static Sprite 

	//public static void Load(){
	////	raindrop = Resources.LoadAssetAtPath<Sprite> ("raindrop.png");
	//}

	private static Sprite LoadEnvironment(string filename){
		return LoadTexture (environment_dir + filename);
	}


	
	private static Sprite LoadTexture (String filename)
	{		
		return Resources.LoadAssetAtPath<Sprite> (filename);		
	}
}

