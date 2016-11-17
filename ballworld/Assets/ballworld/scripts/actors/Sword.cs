using UnityEngine;

public class Sword : MonoBehaviour {

    private SwordState state;
    private Animator animator;    

    void Start()
    {
        animator = GetComponent<Animator>();
    }
	
	void Update () {

        switch (state)
        {
            case SwordState.ATTACKING:
                animator.SetInteger("state", AnimatorState.SWORD_ATTACKING);
                break;
            default:
                animator.SetInteger("state", AnimatorState.IDLE);
                break;
        }
	}

    public void attack()
    {
        state = SwordState.ATTACKING;
    }

    public void idle()
    {
        state = SwordState.IDLE;
    }
}
