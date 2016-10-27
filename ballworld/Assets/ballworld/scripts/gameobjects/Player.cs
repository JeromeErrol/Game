using UnityEngine;
using Assets.ballworld.scripts.engine;

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

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.GetComponent<Fog>() != null)
        {
            float distance = Vector3.Distance(transform.position, collider.gameObject.transform.position);

            // float radius = GetComponent<SphereCollider>().radius;

            // if(distance < radius)
            //   // {
            float a = distance * 2;
            Debug.Log(a);
            GameObjects.setAlpha(collider.gameObject, a);
            // }            
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
