using System.Collections.Generic;
using UnityEngine;

public class Enemy : Unit
{
    public List<Transform> path;
    public int pathIndex = 0;
    public float chaseDistance = 0.4f;
    public float attackDistance = 0.25f;
    public int direction = 1;


    void Update()
    {
        Player player = FindObjectOfType<Player>();
        float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);

        if (distanceToPlayer < chaseDistance)
        {
            faceTowards(player.transform.position);
            if(distanceToPlayer > attackDistance)
            {
                unitState = UnitState.RUNNING_FORWARD;
            }           
        }else if(path.Count > 0)
        {
            Transform target = path[pathIndex];
            if (Vector3.Distance(transform.position, target.position) <= 0.1f)
            {
                pathIndex = pathIndex + direction;
                if(pathIndex < 0 || pathIndex >= path.Count)
                {
                    direction = -direction;
                    pathIndex += direction;
                }
                target = path[pathIndex];
            }
            faceTowards(target.position);
        }else
        {

        }   
    }
}
