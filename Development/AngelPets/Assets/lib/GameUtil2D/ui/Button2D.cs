using UnityEngine;
using System.Collections;

public class Button2D : MonoBehaviour
{
		public Color color = Color.black;
		public GUIStyle style;
		public float alpha;
		public string text;
		public Instruction instruction;
		public bool visible;
	
		void Update ()
		{
				color.a = alpha;
		}
	
		void OnGUI ()
		{
				if (visible) {
						GUI.color = color;
						if (GUI.Button (new Rect (transform.position.x, transform.position.y, Screen.width, 50), text, style)) {
								if (instruction != null) {
										instruction.Run ();
								}
						}
				}
		}
}

