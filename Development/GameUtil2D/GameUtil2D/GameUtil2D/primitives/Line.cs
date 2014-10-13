using UnityEngine;
using System.Collections;

namespace GameUtil2D
{
	public class Line : MonoBehaviour
	{
		public Color color;
		public Vector2 start;
		public Vector2 end;
		public float thickness;

		void Start(){
			renderer.material.SetTexture("LINE", TextureUtil2D.PIXEL_1X1);
		}

		void Update(){

		}
	}
}

