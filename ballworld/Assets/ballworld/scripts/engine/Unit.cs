using UnityEngine;

public class Unit : BallworldObject {

    public UnitState unitState = UnitState.IDLE; 
    public float speed = 0.3f;
    public int health = 5;
    private UnitAnimator animator;
    public HitGroup hitGroup;

    void Start()
    {
        animator = gameObject.AddComponent<UnitAnimator>();
    }

    void FixedUpdate()
    {
        switch (unitState)
        {                      
            case UnitState.RUNNING_FORWARD:
                animator.running();
                moveForward(speed);
                break;
            case UnitState.RUNNING_BACKWARD:
                animator.running();
                moveForward(-speed);
                break;
            case UnitState.STRAFING_LEFT:
                animator.strafing();
                moveSideways(-speed);
                break;
            case UnitState.STRAFING_RIGHT:
                animator.strafing();
                moveSideways(speed);
                break;
            case UnitState.RUNNING_FORWARD_LEFT:
                animator.crossing();
                moveSideways(-halfSpeed);
                moveForward(halfSpeed);
                break;
            case UnitState.RUNNING_FORWARD_RIGHT:
                animator.crossingCW();
                moveSideways(halfSpeed);
                moveForward(halfSpeed);
                break;
            case UnitState.RUNNING_BACKWARDS_LEFT:
                animator.crossingCW();
                moveSideways(-halfSpeed);
                moveForward(-halfSpeed);
                break;
            case UnitState.RUNNING_BACKWARDS_RIGHT:
                animator.crossing();
                moveSideways(halfSpeed);
                moveForward(-halfSpeed);
                break;
            default:
                animator.idle();
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

    public void idle()
    {
        unitState = UnitState.IDLE;
    }

    public void runForward()
    {
        unitState = UnitState.RUNNING_FORWARD;
    }
}
