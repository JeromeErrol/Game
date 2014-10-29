using UnityEngine;
using System.Collections;


namespace GameUtil2D
{	
	public static class EffectUtil2D
	{			
		public static void SetAlpha (Renderer renderer, float a)
		{
			Color color = renderer.material.color;
			color.a = a;
			renderer.material.color = color;
		}			
	}
}