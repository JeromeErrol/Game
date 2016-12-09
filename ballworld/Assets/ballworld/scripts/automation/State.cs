using UnityEngine;
using System.Collections.Generic;

public class State : MonoBehaviour {

    public GameEvent onActivate;
    public GameEvent onActive;
    public GameEvent onDeactivate;
    public List<Transition> transitions;
}
