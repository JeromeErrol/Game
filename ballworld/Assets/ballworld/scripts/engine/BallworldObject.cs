using UnityEngine;

public class BallworldObject : MonoBehaviour {

    public int layer;

    void Start()
    {
        if (GetComponent<MeshRenderer>() != null)
        {
            GetComponent<MeshRenderer>().sortingOrder = layer;

            World world = GameObject.FindObjectOfType<World>();
            transform.position = transform.forward * (world.radius) + (transform.forward.normalized * ((float)layer / 1000f));
        }
    }

    /// <summary>
    /// rotateAroundRightXRed
    /// </summary>
    /// <param name="distance"></param>
    public void moveForward(float distance)
    {
        transform.RotateAround(Vector3.zero, transform.right, -distance);
    }

    public void moveSideways(float distance)
    {
        transform.RotateAround(Vector3.zero, transform.up, -distance);
    }

    public void rotate(float distance)
    {
        transform.RotateAround(Vector3.zero, transform.forward, distance);
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
            return GetComponent<MeshFilter>().mesh.bounds.size.x * transform.lossyScale.x;
        }
    }

    public float height
    {
        get
        {
            return GetComponent<MeshFilter>().mesh.bounds.size.y * transform.lossyScale.y;
        }
    }

    public Vector2 size
    {
        get
        {
            return new Vector2(width, height);
        }
    }

    public void moveTowards(Vector3 position, float distance)
    {
        transform.RotateAround(Vector3.zero, Vector3.Cross(transform.position, position), distance);
    }

    public void faceTowards(Vector3 position)
    {
        transform.rotation = Quaternion.LookRotation(transform.forward, position - transform.position);
    }

    /// <summary>
    /// Moves the object to the correct distance and rotation to the world
    /// </summary>
    public void correctPosition()
    {
        Vector3 forward = transform.position.normalized;
        Vector3 upwards = Vector3.Cross(Vector3.zero, forward);
        transform.rotation = Quaternion.LookRotation(forward, upwards);

        World world = GameObject.FindObjectOfType<World>();
        transform.position = transform.forward * (world.radius);
    }

    /*
    public float degreesBetween(Transform otherTransform)
    {
        Vector3 relative = transform.position - otherTransform.position;
        Vector3 point = Quaternion.Inverse(otherTransform.rotation) * relative;
        Vector2 point2 = new Vector2(point.x, point.y);

        if (point2.x < 0)
        {
            return 360 - (Mathf.Atan2(point2.x, point2.y) * Mathf.Rad2Deg * -1);
        }
        else
        {
            return Mathf.Atan2(point2.x, point2.y) * Mathf.Rad2Deg;
        }
    }

    public Vector3 topLeft
    {
        get
        {
            Vector3 left = (transform.right.normalized * (size.x / 2));
            Vector3 top = (transform.up.normalized * (size.y / 2));
            return transform.position + left + top; 
        }
    }

    public Vector3 bottomLeft
    {
        get
        {
            Vector3 left = transform.right.normalized * (size.x / 2);
            Vector3 bottom = transform.up.normalized * (-size.y / 2);
            return transform.position + left + bottom;
        }
    }
    */
}
