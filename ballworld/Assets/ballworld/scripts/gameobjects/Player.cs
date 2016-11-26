using UnityEngine;

public class Player : MonoBehaviour {
    

    void OnTriggerEnter(Collider collider)
    {      
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
