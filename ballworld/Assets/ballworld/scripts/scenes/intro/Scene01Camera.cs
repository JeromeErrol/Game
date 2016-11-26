using UnityEngine;
using System.Collections;

public class Scene01Camera : MonoBehaviour {

    public float speed = 1f;
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * speed;
	}
}
