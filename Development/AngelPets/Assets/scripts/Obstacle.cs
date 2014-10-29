using UnityEngine;
using System.Collections;

public class Obstacle : PlayerInteractive
{
		public bool startActivated = true;

		void Start(){
			if(startActivated == false){
			if (GetComponent<PolygonCollider2D> () != null) {
				GetComponent<PolygonCollider2D> ().enabled = false;
			}
			
			if (GetComponent<BoxCollider2D> () != null) {
				GetComponent<BoxCollider2D> ().enabled = false;
			}
			
			if (GetComponent<CircleCollider2D> () != null) {
				GetComponent<CircleCollider2D> ().enabled = false;
			}
			}
		}

		public override void PlayerEnter (Player player)
		{
				Level.instance.LoseLife ();			
		}
}

