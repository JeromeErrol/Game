using UnityEngine;
using System.Collections;

public class FadeAGUI : MonoBehaviour {
	public Color color = Color.black;
	public GUIStyle style;
	public float alpha;
	public string text;
	public float fadeSpeed;
	public float x;
	public float y;

	

	void Update () {
		alpha -= fadeSpeed;
		color.a = alpha;
	}
	
	void OnGUI() {
		
		//Color colorSave = GUI.color;
		GUI.color = color;
		GUI.Label (new Rect(x, y, Screen.width,50), text, style);
	}
}