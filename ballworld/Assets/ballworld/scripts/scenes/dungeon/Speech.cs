using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Speech : MonoBehaviour {

    public Text text;
    public List<string> texts;
    private int index = 0;

    public List<EventListener> onFinishedEventListeners;
    public string onFinishedEventName;

    public void nextText()
    {
        if(index++ < texts.Count)
        {
            text.text = texts[index];
        }else
        {
            foreach(EventListener eventListener in onFinishedEventListeners)
            {
                eventListener.trigger(onFinishedEventName);
            }
        }        
    }
}
