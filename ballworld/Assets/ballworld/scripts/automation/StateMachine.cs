using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StateMachine : MonoBehaviour {

    public int index = 0;
    public List<Action> actions; 

	void Update () { 
        if (action.isFinished())
        {
            index = index++ % actions.Count;
        }
        action.perform();
	}

    Action action
    {
        get
        {
            return actions[index]; 
        }
    }
}
