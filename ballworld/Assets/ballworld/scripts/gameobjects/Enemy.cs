using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public List<Transform> path;
    public int pathIndex = 0;
    public float chaseDistance = 0.4f;
    public float attackDistance = 0.08f;
    public int direction = 1;
    public Weapon weapon;
    private Unit unit;



    void Start()
    {
        if (unit == null)
        {
            unit = GetComponent<Unit>();
        }
    }

    void Update()
    {
        Player player = FindObjectOfType<Player>();
        float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);

        if (distanceToPlayer < chaseDistance)
        {
            unit.faceTowards(player.transform.position);
            if (distanceToPlayer < attackDistance)
            {
                unit.idle();
                if (weapon.readyToRelease)
                {
                    weapon.release();
                }
                else
                {
                    weapon.draw();
                }
            }
            else
            {
                unit.runForward();

            }
        }
        else if (path.Count > 0)
        {
            Transform target = path[pathIndex];
            if (Vector3.Distance(transform.position, target.position) <= 0.1f)
            {
                pathIndex = pathIndex + direction;
                if (pathIndex < 0 || pathIndex >= path.Count)
                {
                    direction = -direction;
                    pathIndex += direction;
                }
                target = path[pathIndex];
            }
            unit.faceTowards(target.position);
            unit.runForward();
        }
        else
        {
            wander();
        }
    }

    private void wander()
    {
        weapon.idle();
        if (walkDistance-- > 0)
        {
            unit.runForward();
            idlePause = Random.Range(50, 200);
        }
        else if (idlePause-- > 0)
        {
            unit.idle();
        }
        else
        {
            unit.rotate(Random.Range(0, 360));
            walkDistance = Random.Range(1, 100);
        }
    }

    int idlePause = 100;
    int walkDistance = 100;
}
