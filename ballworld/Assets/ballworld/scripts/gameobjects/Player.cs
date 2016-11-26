using UnityEngine;

public class Player : MonoBehaviour {

    public Transform target;

    void Update()
    {
        Debug.Log( GetComponent<BallworldObject>().distanceBetween(target));
    }

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
