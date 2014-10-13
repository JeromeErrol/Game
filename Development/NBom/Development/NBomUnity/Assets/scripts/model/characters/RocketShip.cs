using UnityEngine;
using System.Collections;
using GameUtil2D;

public class RocketShip :MonoBehaviour
{
		public int points;

		void Start ()
		{
				
		}
	
		void Update ()
		{
				OxygenTank oxygenTank = GetComponent<OxygenTank> ();
				if (oxygenTank && oxygenTank.oxygen.IsZero) {
						Die ();
				}				
				rigidbody2D.angularVelocity = 0; // Prevents spinning during collision with wall.				
		}

		public Teleport teleport {
				get {
						return GetComponent<Teleport> ();
				}
		}

		public void Die ()
		{
				Destroy (gameObject);
				print ("Game Over");
				Application.LoadLevel (Level.instance.levelName);
		}

		void OnTriggerEnter2D (Collider2D collider2D)
		{		
				ICollideable collideable = collider2D.gameObject.GetComponent<ICollideable> ();
				if (collideable) {
						collideable.CollidedWith (this);
				}
		}
	
		void OnTriggerExit2D (Collider2D col)
		{			
				IOverlap overlap = col.gameObject.GetComponent<IOverlap> ();
				if (overlap) {
						overlap.ExitTriggered (this);
				}
		}
	
		void OnTriggerStay2D (Collider2D col)
		{
				IOverlap overlap = col.gameObject.GetComponent<IOverlap> ();
				if (overlap) {
						overlap.OverlapTriggered (this);
				}
		}
}

