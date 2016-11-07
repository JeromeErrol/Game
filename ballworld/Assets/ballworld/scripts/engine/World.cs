using UnityEngine;

public class World : MonoBehaviour {

    public float radius
    {
        get
        {
            return GetComponent<MeshFilter>().sharedMesh.bounds.size.x / 2 * transform.lossyScale.y;
        }
    }
}
