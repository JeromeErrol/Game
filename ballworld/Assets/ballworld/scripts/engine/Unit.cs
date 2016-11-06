using UnityEngine;

public class Unit : BallworldObject {

    public float runSpeed = 0.3f;
    public bool boost = false;
    public float boostAmount = 1.1f;
    public GameObject externalSpriteRenderer;
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
        // set the animation state to standing
        if(externalSpriteRenderer != null) {
            externalSpriteRenderer.GetComponent<Animator>().SetBool("running", false);
        }
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
        moveForward(Speed);
        if (externalSpriteRenderer != null)
        {
          //  externalSpriteRenderer.GetComponent<Animator>().SetBool("running", true);
        }
    }

    public void runBackward()
    {
        moveForward(-Speed);
        if (externalSpriteRenderer != null)
        {
            externalSpriteRenderer.GetComponent<Animator>().SetBool("running", true);
        }
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
