using UnityEngine;

public class Sword : MonoBehaviour {

    public void attack()
    {
        GetComponent<Animator>().SetBool("attack", true);
    }

    public void attachFinished()
    {
        GetComponent<Animator>().SetBool("attack", false);
    }
}
