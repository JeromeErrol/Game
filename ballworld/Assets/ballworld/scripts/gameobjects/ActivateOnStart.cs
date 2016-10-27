using UnityEngine;
using System.Collections;

public class ActivateOnStart : MonoBehaviour {
    
	void Start () {
        GetComponent<SpriteRenderer>().enabled = true;
	}
}
