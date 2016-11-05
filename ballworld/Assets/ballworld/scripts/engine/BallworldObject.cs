using UnityEngine;

public class BallworldObject : MonoBehaviour {
      
    public void moveForward(float distance)
    {
        transform.RotateAround(Vector3.zero, transform.up, distance);
    }

    public void moveSideways(float distance)
    {
        transform.RotateAround(Vector3.zero, -transform.right, distance);
    }

    /***
     * Green Arrow
     **/
    public void moveVertically(float distance)
    {
        transform.RotateAround(Vector3.zero, Vector3.Cross(transform.position, Vector3.up), distance);
    }

    /***
     * Red Arrow
     **/
    public void moveHorizontally(float distance)
    {
        transform.RotateAround(Vector3.zero, Vector3.down, distance);
    }

    public float width
    {
        get
        {
            return GetComponent<SpriteRenderer>().sprite.textureRect.width * transform.localScale.x * 0.5f;
        }
    }

    public float height
    {
        get
        {
            return GetComponent<SpriteRenderer>().sprite.textureRect.height * transform.localScale.y * 0.5f;
        }
    }
}
