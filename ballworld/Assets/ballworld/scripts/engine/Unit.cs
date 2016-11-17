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
            case UnitState.IDLE:
                setAnimatorState(AnimatorState.IDLE);
                break;
            case UnitState.RUNNING_FORWARD:
                setAnimatorState(AnimatorState.RUNNING);
                moveForward(speed);
                break;
            case UnitState.RUNNING_BACKWARD:
                setAnimatorState(AnimatorState.RUNNING);
                moveForward(-speed);
                break;
            case UnitState.STRAFING_LEFT:
                setAnimatorState(AnimatorState.STRAFING);
                moveSideways(-speed);
                break;
            case UnitState.STRAFING_RIGHT:
                setAnimatorState(AnimatorState.STRAFING);
                moveSideways(speed);
                break;
            case UnitState.RUNNING_FORWARD_LEFT:
                setAnimatorState(AnimatorState.CROSSING);
                moveSideways(-halfSpeed);
                moveForward(halfSpeed);
                break;
            case UnitState.RUNNING_FORWARD_RIGHT:
                setAnimatorState(AnimatorState.CROSSING_CW);
                moveSideways(halfSpeed);
                moveForward(halfSpeed);
                break;
            case UnitState.RUNNING_BACKWARDS_LEFT:
                setAnimatorState(AnimatorState.CROSSING);
                moveSideways(-halfSpeed);
                moveForward(-halfSpeed);
                break;
            case UnitState.RUNNING_BACKWARDS_RIGHT:
                setAnimatorState(AnimatorState.CROSSING_CW);
                moveSideways(halfSpeed);
                moveForward(-halfSpeed);
                break;
            default:                
                break;
        }
    }

    public float halfSpeed
    {
        get
        {
            return speed / 2;
        }
    }

    private void setAnimatorState(int state)
    {
        animator.SetInteger("state", state);
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
