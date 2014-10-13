using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour
{
		void Start ()
		{
				Patrol patrol = gameObject.AddComponent<Patrol> ();
				patrol.movementSpeed = 0.03f;
				patrol.targetRadius = 0.03f;
				renderer.sortingOrder = 100;			
				gameObject.AddComponent<Rigidbody2D> ().gravityScale = 0;
				patrol.patrolPoints.Add (Hierarchy.instance.patrol01);
				patrol.patrolPoints.Add (Hierarchy.instance.patrol02);
				patrol.patrolPoints.Add (Hierarchy.instance.patrol03);
				patrol.patrolPoints.Add (Hierarchy.instance.patrol04);
				patrol.patrolPoints.Add (Hierarchy.instance.patrol05);
				patrol.patrolPoints.Add (Hierarchy.instance.patrol06);
				patrol.patrolPoints.Add (Hierarchy.instance.patrol07);
				patrol.patrolPoints.Add (Hierarchy.instance.patrol08);
				patrol.patrolPoints.Add (Hierarchy.instance.patrol09);
				patrol.patrolPoints.Add (Hierarchy.instance.patrol10);
				patrol.patrolPoints.Add (Hierarchy.instance.patrol11);
				patrol.patrolPoints.Add (Hierarchy.instance.patrol12);
				patrol.patrolPoints.Add (Hierarchy.instance.patrol13);
		}

		void Update ()
		{
				float distance = Vector3.Distance (transform.position, Hierarchy.instance.center.transform.position);
				if (distance < 3) {
						GameObject.Destroy (this);
				}
		}


}

