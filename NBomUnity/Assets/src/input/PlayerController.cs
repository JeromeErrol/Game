using System.Collections;
using UnityEngine;
using AssemblyCSharp;

public class PlayerController : MonoBehaviour
{
		public RocketShip rocketShip;		

		void Update ()
		{		
				if (Input.GetMouseButtonDown (0)) {
						MouseUtil2D.FaceMouse (rocketShip.gameObject);
						rocketShip.FireThruster ();
				}
		}
}
