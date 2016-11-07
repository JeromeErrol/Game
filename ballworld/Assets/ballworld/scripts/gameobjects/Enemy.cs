using System.Collections.Generic;
using UnityEngine;

public class Enemy : Unit
{
    public Animator animator;
    public List<Transform> path;
    public int pathIndex = 0;

    void Update()
    {
        if (animator.GetBool("running"))
        {
            faceTowards(currentTarget.position);
            runForward();
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.GetComponent<Player>() != null)
        {
            animator.SetBool("running", false);
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.GetComponent<Player>() != null)
        {
            animator.SetBool("running", true);
        }
    }

    public Transform currentTarget
    {
        get
        {
            Transform target = path[pathIndex];
            
            if (Vector3.Distance(transform.position, target.position) < 0.022f)
                {
                    return path[(pathIndex + 1) % path.Count];
                }
            return target;
        }
    }
}
