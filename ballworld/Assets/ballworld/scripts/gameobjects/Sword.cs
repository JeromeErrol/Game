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
}
