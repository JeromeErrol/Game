using UnityEngine;

public class ActivateOnStart : MonoBehaviour {
    
	void Start () {
        GetComponent<SpriteRenderer>().enabled = true;
	}
}
