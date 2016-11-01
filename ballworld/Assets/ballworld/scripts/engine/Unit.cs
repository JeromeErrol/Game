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
        GetComponent<RunAnimation>().running = false;

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
        GetComponent<RunAnimation>().running = true;
        if (externalSpriteRenderer != null)
        {
            externalSpriteRenderer.GetComponent<Animator>().SetBool("running", true);
        }
    }

    public void runBackward()
    {
        moveForward(-Speed);
        GetComponent<RunAnimation>().running = true;
    }

    public void strafeLeft()
    {
        moveSideways(-Speed);
        GetComponent<RunAnimation>().running = true;
    }

    public void strafeRight()
    {
        moveSideways(Speed);
        GetComponent<RunAnimation>().running = true;
    }

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.GetComponent<CircleObstacle>() != null)
        {
            OnTriggerEnter(collider);
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.GetComponent<CircleObstacle>() != null && collider.GetComponent<SphereCollider>() != null)
        {
            //  transform.RotateAround(Vector3.zero, Vector3.Cross(gameObject.transform.position, collider.gameObject.transform.position), -1f);
            float distanceBetween = Vector3.Distance(transform.position, collider.gameObject.transform.position);
            float combinedRadius = GetComponent<SphereCollider>().radius + collider.GetComponent<SphereCollider>().radius;
            float crossOver = distanceBetween - combinedRadius;
            transform.RotateAround(Vector3.zero, Vector3.Cross(gameObject.transform.position, collider.gameObject.transform.position), crossOver * collider.GetComponent<CircleObstacle>().pushAmount);
        }

        if (collider.gameObject.GetComponent<BoxObstacle>() != null && collider.GetComponent<BoxCollider>() != null)
        {
            transform.RotateAround(Vector3.zero, collider.transform.up, 0.5f);
        }
    }   
}
