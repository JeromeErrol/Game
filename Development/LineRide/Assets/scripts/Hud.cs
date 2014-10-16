using UnityEngine;
using System.Collections;

public class Hud : MonoBehaviour
{	
	public float x = 5;
	public float y = 5;


	void OnGUI(){
		GUI.color = Color.white;
		float width = Screen.width / 5;
		if (GUI.Button (new Rect (Screen.width - width, y, (width), 50), "Menu")) {
			MainMenu.instance.Toggle();
		}
	}
}

