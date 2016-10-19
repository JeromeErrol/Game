using System.Collections.Generic;
using UnityEngine;

public class Flocking : MonoBehaviour {   

    public List<Transform> waypoints;
    public int currentWaypointIndex = 0;
    public float raycastDistance = 5;
    public bool obstacleDetected;

    public Vector2 alternativeWaypoint;

    public Transform sight;

    public Transform currentWaypoint
    {
        get
        {
            if (waypoints.Count > 0)
            {
                return waypoints[currentWaypointIndex];
            }
            return transform;
        }
    }

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        obstacleDetected = true;
        // create a new alternative way point to the right of the current waypoint
        Vector3 difference = transform.position - currentWaypoint.position;
        Vector3 between = transform.position + difference / 2;
        Vector3 t = Vector3.Cross(transform.position, currentWaypoint.position);

        Vector3 newVector = between + t;
      //  Vector3 shiftRight = between.
    }

    void OnTriggerExit2D(Collider2D collider2D)
    {
        obstacleDetected = false;
    }

    public bool pathIntercectionDetected()
    {
        RaycastHit2D raycastHit = Physics2D.Linecast(transform.position, sight.position);        
        return raycastHit.collider != null && raycastHit.collider.gameObject != gameObject;
    }
	
	void Update () {
        Unit unit = GetComponent<Unit>();
        unit.lookAt(currentWaypoint);        

        if (distanceFromTarget > 1)
        {
            if (obstacleDetected) {
                unit.rotation += 0.1f;
            }
            else
            {
                unit.run();
            }
        }
        else
        {
            if (waypoints.Count > 0)
            {
                currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Count;
            }
        }

        Debug.DrawLine(transform.position, sight.position, Color.blue, 0.1f, false);
    }    

    float distanceFromTarget
    {
        get
        {
            return Vector2.Distance(transform.position, currentWaypoint.position);
        }
    }
}
