using UnityEngine;
using System.Collections;

public class AlphaFade : MonoBehaviour
{
		public float fadeSpeed = 0;
		public float alpha = 1;


		void Update ()
		{
			alpha += fadeSpeed;
			Color c = renderer.material.color;
			c.a = alpha;
			renderer.material.color = c;
		}
}

