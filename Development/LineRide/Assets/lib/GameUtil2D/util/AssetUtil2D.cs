using UnityEngine;
using System.Collections;
using System;

namespace GameUtil2D
{
		public static class AssetUtil2D
		{
				public static String texture_dir = "Assets/textures/";

	
				public static Sprite LoadTexture (String filename)
				{		
					return Resources.LoadAssetAtPath<Sprite> (texture_dir + filename);		
				}
		}
}

