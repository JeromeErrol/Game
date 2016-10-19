using UnityEngine;
using System.Collections;

public class CameraTrack : MonoBehaviour {

    public Transform target;
    public float xOffset = 0;
    public float yOffset = 0;

    void LateUpdate()
    {
        transform.position = new Vector3(target.transform.position.x + xOffset,
                                              target.transform.position.y + yOffset,
                                              transform.position.z);
        transform.rotation = target.rotation;

    }
}
