using UnityEngine;

public class Unit : BallworldObject {

    public float runSpeed = 0.3f;
    public bool boost = false;
    public float boostAmount = 1.1f;
    public Animator animator;
    public Sword sword;
    
    public float Speed
    {
        get
        {
            if (boost)
            {
                return runSpeed * boostAmount;
            }
            return runSpeed;
        }
    }

    public void standStill()
    {
        animator.SetBool("running", false);
    }

    public void attack()
    {
        if(sword != null)
        {
            sword.attack();
        }
    }

    public void runForward()
    {
        animator.SetBool("running", true);
        moveForward(Speed);
    }

    public void runBackward()
    {
        animator.SetBool("running", true);
        moveForward(-Speed);
    }

    public void strafeLeft()
    {
        moveSideways(-Speed);
    }

    public void strafeRight()
    {
        moveSideways(Speed);
    }     
}
