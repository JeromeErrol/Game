using UnityEngine;
using System.Collections;

public class ScreenText : MonoBehaviour
{
	public float x;
	public float y;
	public float width;
	public float height;
	public string text;

	void OnGUI(){
		GUI.Box (new Rect (x, y, width, height), text);
	}
}

