using UnityEngine;
using System.Collections;

public class UnitBehavior : MonoBehaviour {

    private Unit unit;
    public bool runForward;
    
	void Start () {
        unit = GetComponent<Unit>();
	}
	
	void Update () {
        if (runForward)
        {
            unit.runForward();
        }
	}
}
