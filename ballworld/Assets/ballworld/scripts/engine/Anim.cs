using UnityEngine;

public class Anim : MonoBehaviour {

    protected Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public int state
    {
        set
        {            
           animator.SetInteger("state", value);
        }
    }    
}
