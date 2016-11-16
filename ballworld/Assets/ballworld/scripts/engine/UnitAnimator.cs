using UnityEngine;

public class UnitAnimator : MonoBehaviour {

    private Animator animator;
    public Unit unit;

        
	void Start () {
        animator = GetComponent<Animator>();       
	}

    public void startRunning()
    {
        animator.SetBool("running", true);
    }

    public void stopRunning()
    {
        animator.SetBool("running", false);
    }

    public void startAttacking()
    {
        animator.SetBool("attacking", true);
    }

    public void stopAttacking()
    {
        animator.SetBool("attacking", false);
    }
}
