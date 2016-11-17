using UnityEngine;

public class Unit : BallworldObject {

    public UnitState unitState = UnitState.IDLE; 
    public float speed = 0.3f;
    public int health = 5;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        switch (unitState)
        {                      
            case UnitState.RUNNING_FORWARD:
                animator.SetInteger("state", AnimatorState.RUNNING);
                moveForward(speed);
                break;
            case UnitState.RUNNING_BACKWARD:
                animator.SetInteger("state", AnimatorState.RUNNING);
                moveForward(-speed);
                break;
            case UnitState.STRAFING_LEFT:
                animator.SetInteger("state", AnimatorState.STRAFING);
                moveSideways(-speed);
                break;
            case UnitState.STRAFING_RIGHT:
                animator.SetInteger("state", AnimatorState.STRAFING);
                moveSideways(speed);
                break;
            case UnitState.RUNNING_FORWARD_LEFT:
                animator.SetInteger("state", AnimatorState.CROSSING);
                moveSideways(-halfSpeed);
                moveForward(halfSpeed);
                break;
            case UnitState.RUNNING_FORWARD_RIGHT:
                animator.SetInteger("state", AnimatorState.CROSSING_CW);
                moveSideways(halfSpeed);
                moveForward(halfSpeed);
                break;
            case UnitState.RUNNING_BACKWARDS_LEFT:
                animator.SetInteger("state", AnimatorState.CROSSING_CW);
                moveSideways(-halfSpeed);
                moveForward(-halfSpeed);
                break;
            case UnitState.RUNNING_BACKWARDS_RIGHT:
                animator.SetInteger("state", AnimatorState.CROSSING);
                moveSideways(halfSpeed);
                moveForward(-halfSpeed);
                break;
            default:
                animator.SetInteger("state", AnimatorState.IDLE);
                break;
        }
    }

    public float halfSpeed
    {
        get
        {
            return speed * 0.66f;
        }
    }

    public void takeDamage()
    {
        health--;
        Debug.Log("Damage taken: " + health);
        if (health <= 0)
        {
            //die();
        }
    }
}
