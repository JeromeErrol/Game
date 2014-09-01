using System.Collections;
using UnityEngine;
using GameUtil2D;

public class RocketShipController : MonoBehaviour
{
		public RocketShip rocketShip;
	
		void FixedUpdate ()
		{		
				if (FireBoostThrusterEvent) {
						MouseUtil2D.FaceMouse (rocketShip.gameObject);
						rocketShip.BoostThruster ();
				}

				if (FireChargeBurstThrusterEvent) {
						MouseUtil2D.FaceMouse (rocketShip.gameObject);
						rocketShip.ChargeBurstThruster ();
				}

				if (FireReleaseBurstThrustEvent) {
						rocketShip.ReleaseBurstThruster ();
				}			
		}

		bool FireBoostThrusterEvent {
				get {
						return Input.GetMouseButton (0);
				}
		}

		bool FireChargeBurstThrusterEvent {
				get {
						return Input.GetMouseButton (1);
				}
		}

		bool FireReleaseBurstThrustEvent {
				get {
						return FireChargeBurstThrusterEvent == false && rocketShip.BurstCharged; 
				}
		}
}
