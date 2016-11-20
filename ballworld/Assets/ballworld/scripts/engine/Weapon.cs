using UnityEngine;

public abstract class Weapon : MonoBehaviour {

    private WeaponAnimator animator;
    public WeaponState state = WeaponState.IDLE;

    void Start()
    {
        animator = gameObject.AddComponent<WeaponAnimator>();
    }

    void Update()
    {
        switch (state)
        {
            case WeaponState.DRAWN:
                animator.drawn();
                break;
            case WeaponState.RELEASING:
                animator.releasing();
                break;
            default:
                animator.idle();
                break;
        }
    }

    public void releaseFinished()
    {
            state = WeaponState.IDLE;
    }

    public void draw()
    {
        state = WeaponState.DRAWN;
    }

    public void idle()
    {
        state = WeaponState.IDLE;
    }
    
    public bool readyToRelease
    {
        get
        {
            return state == WeaponState.DRAWN;
        }
    }

    public void release()
    {
            state = WeaponState.RELEASING;
            released();
    }

    public abstract void released();
    
}
