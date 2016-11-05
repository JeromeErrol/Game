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

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.GetComponent<CircleObstacle>() != null && collider.GetComponent<SphereCollider>() != null)
        {
            transform.RotateAround(Vector3.zero, Vector3.Cross(gameObject.transform.position, collider.gameObject.transform.position), -1f);         
        }

        if (collider.gameObject.GetComponent<BoxObstacle>() != null && collider.GetComponent<BoxCollider>() != null)
        {
            Vector2 size = collider.GetComponent<BallworldObject>().size;   
            Vector3 relative = transform.position - collider.transform.position;
            Vector3 point = Quaternion.Inverse(collider.transform.rotation) * relative;
            Vector3 left = (collider.transform.right.normalized * (size.x / 2));
            Vector3 right = (collider.transform.right.normalized * (-size.x / 2));
            Vector3 top = (collider.transform.up.normalized * (size.y / 2));
            Vector3 topLeft = left + top;
            Vector3 topRight = top + right;

            float dotA = Vector3.Dot(topLeft, relative);
            float dotB = Vector3.Dot(topRight, relative);

            bool a = dotA > 0;
            bool b = dotB > 0;            

            if (a && b)
            {
                transform.RotateAround(Vector3.zero, collider.transform.right, -1f);
            }
            else if (a && !b)
            {
                transform.RotateAround(Vector3.zero, collider.transform.up, 1f);

            }
            else if(!a && b)
            {
                transform.RotateAround(Vector3.zero, collider.transform.up, -1f);
            }
            else
            {
                transform.RotateAround(Vector3.zero, collider.transform.right, 1f);
            }
        }
    }
}
