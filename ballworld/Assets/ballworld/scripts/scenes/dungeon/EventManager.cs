
using System.Collections.Generic;
using UnityEngine;

public class EventManager : EventListener {
    

    void Start () {
        trigger("start game");
	}

    public override void trigger(string eventName)
    {
        if(eventName == "start game")
        {
           // GameObject.Find("IntroAnimation").SetActive(true);
        }



        // blep on event
        // on start event load animation
    }
}
