using UnityEngine;

public class Unit : BallworldObject {

    public UnitState _unitState = UnitState.IDLE; 
    public float speed = 0.3f;
    public int health = 5;
    private UnitAnimator animator;
    public HitGroup hitGroup;
    public AudioSource audioSource;
    

    void Start()
    {
        animator = gameObject.AddComponent<UnitAnimator>();
        audioSource = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        switch (_unitState)
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
            case UnitState.DYING:
                animator.dying();
                break;
            default:
                animator.idle();
                break;
        }
    }    

    public UnitState unitState
    {
       set {
            if(_unitState != value && _unitState != UnitState.DYING)
            {
                _unitState = value;
            }
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
        if (health-- <= 0)
        {
            die();
        }
        Debug.Log("Health: " + health);
    }

    public void idle()
    {
        unitState = UnitState.IDLE;
    }

    public void runForward()
    {
            unitState = UnitState.RUNNING_FORWARD;
    }

    public void die()
    {
        unitState = UnitState.DYING;
    }

    public void destroyGameObject()
    {
        Destroy(gameObject);
    }

    
    public void stepFinished()
    {
        // play audio
        if(audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
