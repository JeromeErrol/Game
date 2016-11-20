using UnityEngine;

public class UnitAnimator : MonoBehaviour {

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void idle()
    {
        animator.SetInteger("state", 0);
    }

    public void running()
    {
        animator.SetInteger("state", 1);
    }

    public void strafing()
    {
        animator.SetInteger("state", 2);
    }

    public void crossing()
    {
        animator.SetInteger("state", 3);
    }

    public void crossingCW()
    {
        animator.SetInteger("state", 4);
    }
}
