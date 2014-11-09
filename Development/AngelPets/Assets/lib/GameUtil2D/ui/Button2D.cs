using UnityEngine;
using System.Collections;

public class Button2D : MonoBehaviour
{
		public Color color = Color.black;
		public GUIStyle style;
		public float alpha = 1;
		public string text;
		public float x;
		public float y;
		public bool visible = true;
		public Instruction instruction;
	
		void Update ()
		{
				color.a = alpha;
		}
	
		void OnGUI ()
		{
				if (visible) {
						GUI.color = color;
						if (GUI.Button (new Rect (x, y, Screen.width, 50), text, style)) {
								if (instruction != null) {
										instruction.Run ();
								}
						}
				}
		}
}

