using UnityEngine;

public class Sword : MonoBehaviour {

    public GameObject owner;
    public float power = 1;

    public void attack()
    {      
            GetComponent<Animator>().SetBool("attacking", true);
    }

    public void attackFinished()
    {
        GetComponent<Animator>().SetBool("attacking", false);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject != gameObject && collider.GetComponent<Unit>() != null)
        {
            Debug.Log("sword collision");
        //    Vector3 cross = Vector3.Cross(transform.position, collider.gameObject.transform.position);
          //  collider.gameObject.transform.RotateAround(Vector3.zero, cross, power);
        }
    }
}
