using UnityEngine;
using System.Collections;

public class Slide : MonoBehaviour {
    
	void Update () {
        GetComponent<Unit>().runForward();
    }
}
