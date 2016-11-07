using UnityEngine;
using Assets.ballworld.scripts.engine;

public class Player : MonoBehaviour {
    
    void OnTriggerEnter(Collider collider)
    {  
        if (collider.gameObject.GetComponent<Coin>() != null) {
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
