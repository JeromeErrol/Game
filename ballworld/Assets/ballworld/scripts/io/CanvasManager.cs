using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class CanvasManager : MonoBehaviour {

    private static CanvasManager instance;
    public Text text;
    public Image image;
    public int index = 0;
    public List<string> messages;

    void Start()
    {
        instance = this;
        text.text = messages[index];
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }

    void nextMessage()
    {
        text.text = messages[index++];
    }
}
