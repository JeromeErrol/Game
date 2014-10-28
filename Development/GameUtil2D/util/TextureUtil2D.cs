using UnityEngine;
using System.Collections;

public class TextureUtil2D 
{
	public static Texture2D PIXEL_1X1;

	public static void Load(){
		PIXEL_1X1 = CreatePixel(Color.white);
	}

	public static Texture2D CreatePixel (Color color) {
		Texture2D texture = new Texture2D(1, 1, TextureFormat.ARGB32, false);
		texture.SetPixel(0, 0, color);
		texture.Apply();
		return texture;
	}
}

