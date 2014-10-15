using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{
		public float top = 0;
		float x = 100;
		float y = 10;
		public float width = 150;
		public float height = 50;
		public float gap = 20;
		public bool visible = true;
	public bool inGame = true;

		void OnGUI ()
		{
				if (visible) {
						y = top;

						if(inGame){
							if(AddButton("Resume")){

							}
						}
						
						if (AddButton ("New Game")) {
								Level.RestartGame ();
						}
						if (AddButton ("Exit")) {
								Application.Quit ();
						}
				}
		}

		bool AddButton (string text)
		{		
				y += height + gap;
				return GUI.Button (new Rect (x, y, width, height), text);
		}
}

