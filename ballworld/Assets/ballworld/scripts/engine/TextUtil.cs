using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextUtil : MonoBehaviour {

    public static TextUtil instance;
    public Text text;

	void Start () {
        instance = this;
        text = GetComponent<Text>();
	}

    public void setText(string value)
    {
        text.text = value;
    }
	
	public static void set(string value)
    {
        instance.setText(value);
    }
}
