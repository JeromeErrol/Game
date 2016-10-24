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
        
        if(collider.gameObject.GetComponent<Signpost>() != null)
        {
            collider.gameObject.GetComponent<Signpost>().viewFront();
        }       
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.GetComponent<Signpost>() != null)
        {
            collider.gameObject.GetComponent<Signpost>().viewTop();
        }
    }




}
