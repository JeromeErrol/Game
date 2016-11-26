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
    /// Rotate Around Right X Red
    /// </summary>
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

    public float rotation
    {
        get
        {
            return transform.localEulerAngles.z;
        }set
        {
            Vector3 eulerAngles = transform.localEulerAngles;
            eulerAngles.z = value;
            transform.localEulerAngles = eulerAngles;
        }
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

    public void addForce(Vector3 axis, float amount)
    {
        Force force = gameObject.AddComponent<Force>();
        force.axis = axis;
        force.amount = amount;
    }

    public void addVerticalForce(float amount)
    {
        VerticalForce verticalForce = gameObject.AddComponent<VerticalForce>();
        verticalForce.amount = amount;            
    }

    public static float distanceBetween(Vector3 a, Vector3 b)
    {
        float angleFromCenter = Vector3.Angle(a, b);
        float radius = Vector3.Distance(Vector3.zero, a);
        return 2 * Mathf.PI * radius * (angleFromCenter / 360);
    }

    public float distanceBetween(Transform target)
    {
        float angleFromCenter = Vector3.Angle(transform.position, target.position);
        float radius = Vector3.Distance(Vector3.zero, transform.position);
        return 2 * Mathf.PI * radius * (angleFromCenter / 360);
    }
}
