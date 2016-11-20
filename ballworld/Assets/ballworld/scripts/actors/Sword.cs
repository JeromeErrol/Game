using UnityEngine;

public class Sword : MonoBehaviour {
    
    private SwordState state;
    private Animator animator;
    public Arrow arrow;

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
            case SwordState.BOW_IDLE:
                animator.SetInteger("state", AnimatorState.BOW_IDLE);
                break;
            case SwordState.BOW_DRAWN:
                animator.SetInteger("state", AnimatorState.BOW_DRAWN);
                break;
            case SwordState.BOW_RELEASE_ARROW:
                animator.SetInteger("state", AnimatorState.BOW_RELEASE_ARROW);
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

    public void bowIdle()
    {
        state = SwordState.BOW_IDLE;
    }

    public void bowReleaseArrow()
    {
        state = SwordState.BOW_RELEASE_ARROW;
    }

    public void drawBow()
    {
        state = SwordState.BOW_DRAWN;
    }

    public void fireArrow()
    {
        bowIdle();        
        Arrow newArrow = Instantiate(arrow);
        newArrow.transform.position = transform.position;
        newArrow.transform.rotation = transform.rotation;
        newArrow.GetComponent<Hitbox>().owner = transform.parent.gameObject;
    }
}
