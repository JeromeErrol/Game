using UnityEngine;

public class Sword : MonoBehaviour {

    public GameObject owner;
    public Hitbox hitbox;
    public float power = 1;

    void Start()
    {
        Physics.IgnoreCollision(owner.GetComponent<Collider>(), GetComponent<Collider>());
    }

    public bool attack
    {
        get
        {
            return GetComponent<Animator>().GetBool("attack");
        }set
        {
            GetComponent<Animator>().SetBool("attack", value);
          //  GameObject.Instantiate(hitbox, transform.position, GameObject.FindGameObjectWithTag("hitboxes").transform);
        }
    } 
}
