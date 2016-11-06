using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Automation : MonoBehaviour
{
    public float speed;
    public List<Transform> path;
    public int pathIndex = 0;
    
    void Update()
    {
        Transform target = path[pathIndex];

        if(target != null)
        { 
            if(Vector3.Distance(transform.position, target.position) < 0.022f)
            {
                pathIndex = (pathIndex + 1) % path.Count;
                target = path[pathIndex];
            }
            transform.RotateAround(Vector3.zero, Vector3.Cross(transform.position, target.position), speed);
        }
    }
}
