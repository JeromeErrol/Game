using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.GetComponent<Enemy>() != null)
        {           
            Debug.Log("game over");
        }

        if (collider.gameObject.GetComponent<Gold>() != null) {
            GameObject.Destroy(collider.gameObject);
        };
    }    
}
