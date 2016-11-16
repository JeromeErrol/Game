using UnityEngine;

public class Unit : BallworldObject {

    public const int IDLE = 0;
    public const int RUNNING = 1;
    public const int ATTACKING = 2;
    public const int DIE = 4;

    public float speed = 0.3f;
    public Animator animator;
    public int health = 5;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        switch (state)
        {            
            case IDLE:
                break;
            case RUNNING:
                moveForward(speed);
                break;
            default:                
                break;
        }
    }

    public int state
    {
        get
        {
            return animator.GetInteger("state");
        }
        set
        {
            animator.SetInteger("state", value);
        }
    }

    public void idle()
    {
        state = IDLE;
    }

    public void attack()
    {
        Debug.Log("attack");
        state = ATTACKING;
    }    
    
    public void stopRunning()
    {        
        state = IDLE;
    }

    public void runForward()
    {
        state = RUNNING;
    }

    public void runBackward()
    {
        animator.SetBool("running-backward", true);
    }

    public void strafeLeft()
    {
        animator.SetBool("left", true);
    }

    public void strafeRight()
    {
        animator.SetBool("strafing-right", true);
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
        state = DIE;
    }
}
