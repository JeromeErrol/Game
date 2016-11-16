using UnityEngine;

public class Unit : BallworldObject {

    public float runSpeed = 0.3f;
    public Animator animator;
    public int health = 100;

    public void attack()
    {
        animator.SetBool("attacking", true);
    }

    public void attackFinished()
    {
        animator.SetBool("attacking", false);
    }
    
    public float Speed
    {
        get
        {
            return runSpeed;
        }
    }

    public void standStill()
    {
        animator.SetBool("running", false);
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

    public void takeDamage()
    {
        health--;
        Debug.Log("Damage taken: " + health);
        if (health <= 0)
        {
            die();
        }
    }

    public void die()
    {
        Debug.Log("dead");
        animator.SetTrigger("die");
    }
}
