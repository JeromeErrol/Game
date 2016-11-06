using UnityEngine;
using System.Collections;

public class World : MonoBehaviour {

    public float radius
    {
        get
        {
            return GetComponent<MeshFilter>().mesh.bounds.size.x / 2 * transform.lossyScale.y;
        }
    }
}
