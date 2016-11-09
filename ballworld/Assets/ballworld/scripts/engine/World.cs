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
}
