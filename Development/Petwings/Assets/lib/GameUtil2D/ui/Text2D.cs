using UnityEngine;
using System.Collections;

public class Text2D : MonoBehaviour
{
		public Color color = Color.black;
		public GUIStyle style;
		public float alpha = 1;
		public string text;
		public float x;
		public float y;

		void Start ()
		{
				color.a = alpha;
				GUI.color = color;
		}

		protected virtual void UpdateText ()
		{

		}
	
		void Update ()
		{
				color.a = alpha;
				GUI.color = color;
				UpdateText ();

		}
	
		void OnGUI ()
		{
				GUI.color = color;
				GUI.contentColor = color;
				GUI.Label (new Rect (x, y, Screen.width, 50), text, style);
		}
}