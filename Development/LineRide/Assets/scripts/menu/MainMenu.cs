using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{
		public static MainMenu instance;
		public float top = 0;
		private float x = Screen.width / 4;
		float y = 10;
		private float width = Screen.width / 2;
		private float height = Screen.height / 5;
		public float gap = 20;
		private bool open = false;
		public bool inGame = true;

		void Start ()
		{
				MainMenu.instance = this;

				if (!inGame) {
						Open ();
				}
		}

		void OnGUI ()
		{
				if (open) {
						y = top;
						
						if (inGame) {
								if (AddButton ("Resume")) {
										Close ();
								}
						}
						
						if (AddButton ("New Game")) {
								Level.RestartGame ();
								Close ();
						}
						if (AddButton ("Exit")) {
								Application.Quit ();
						}
				}					
		}

		public void Open ()
		{
				Level.Paused = true;
				open = true;
		}

		public void Toggle ()
		{
				if (open) {
						Close ();
				} else {
						Open ();
				}
		}

		public void Close ()
		{
				Level.Paused = false;
				open = false;
		}

		bool AddButton (string text)
		{		
				y += height + gap;
				return GUI.Button (new Rect (x, y, width, height), text);
		}
}

