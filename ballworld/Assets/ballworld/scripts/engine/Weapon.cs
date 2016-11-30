
using UnityEngine;

public abstract class Weapon : BallworldObject {

    private WeaponAnimator animator;
    private WeaponState state = WeaponState.IDLE;

    public AudioClip releaseAudioClip;
    private AudioSource releaseAudioSource;

    public float force = 0f;
    public float maxForce = 2.5f;
    private float MIN_FORCE = 1f;

    void Start()
    {
        animator = gameObject.AddComponent<WeaponAnimator>();
        releaseAudioSource = gameObject.AddComponent<AudioSource>();
        releaseAudioSource.clip = releaseAudioClip;
    }

    void Update()
    {
        switch (state)
        {
            case WeaponState.DRAWN:
                 animator.drawn();
                force = Mathf.Clamp((force * 1.01f), MIN_FORCE, maxForce);
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
        idle();
        force = MIN_FORCE;
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
        if (readyToRelease)
        {
            state = WeaponState.RELEASING;
            releaseAudioSource.Play();
            released();
        }
    }

    public abstract void released();
    
}
