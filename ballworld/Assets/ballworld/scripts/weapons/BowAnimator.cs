using UnityEngine;

public class BowAnimator : MonoBehaviour {

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void idle()
    {
        animator.SetInteger("state", 0);
    }

	public void drawn()
    {
        animator.SetInteger("state", 1);
    }

    public void releasing()
    {
        animator.SetInteger("state", 2);
    }
}
