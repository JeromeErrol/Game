using UnityEngine;
using System.Collections;

public class Hud : MonoBehaviour
{	
	public float x = 5;
	public float y = 5;

	void Start(){
	}

	void OnGUI(){
		GUI.color = Color.white;

		GUI.Label(new Rect(x, y, 100f, 20), "Level:" + Level.instance.level);
		GUI.Label(new Rect(x, y + 25, 100f, 20), "Lives:" + Player.livesRemaining);

		float width = Screen.width / 5;

		if (GUI.Button (new Rect (Screen.width - width, y, (width), 50), "Menu")) {
			MainMenu.instance.Toggle();
		}
	}
}

