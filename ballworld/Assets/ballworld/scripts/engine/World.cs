using UnityEngine;

public class World : MonoBehaviour {

    void Start()
    {
        GetComponent<MeshRenderer>().sortingOrder = -1;
    }

    public float radius
    {
        get
        {
            return GetComponent<MeshFilter>().sharedMesh.bounds.size.x / 2 * transform.lossyScale.y;
        }
    }

    /// <summary>
    /// Moves the object to the correct distance and rotation to the world
    /// </summary>
    public void correctPosition(Transform transform)
    {
        Vector3 forward = transform.position.normalized;
        Vector3 upwards = Vector3.Cross(Vector3.zero, forward);
        transform.rotation = Quaternion.LookRotation(forward, upwards);

        World world = GameObject.FindObjectOfType<World>();
        transform.position = transform.forward * (world.radius);
    }
}
