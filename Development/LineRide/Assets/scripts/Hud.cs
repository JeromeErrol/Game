using UnityEngine;
using System.Collections;

public class Hud : MonoBehaviour
{	
	public float x = 5;
	public float y = 5;


	void OnGUI(){
		GUI.Box (new Rect (x, y, 100f, 25f), "Level:" + Level.instance.level);
		GUI.Box (new Rect (x, y + 25, 100f, 25f), "Lives:" + Player.livesRemaining);
	}
}

