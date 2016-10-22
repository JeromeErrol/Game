using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {

    public float amount;
    	
	
	void Update () {
        Quaternion rotation = transform.rotation;
        Vector3 eurlerAngles = transform.rotation.eulerAngles;
        eurlerAngles.z += amount;
        rotation.eulerAngles = eurlerAngles;
        transform.rotation = rotation;
    }
}
