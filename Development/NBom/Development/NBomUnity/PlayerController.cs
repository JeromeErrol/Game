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
			rocketShip.BoostThruster ();
		}

		if (GetMouseButtonDown (1)) {
			MouseUtil2D.FaceMouse (rocketShip.gameObject);
			rocketShip.
		}

				

		
	}
}
