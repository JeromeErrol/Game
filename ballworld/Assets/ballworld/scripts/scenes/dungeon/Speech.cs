using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Speech : MonoBehaviour {

    public Text text;
    public List<string> texts;
    private int index = 0;

    public void nextText()
    {
        text.text = texts[index++];
    }
}
