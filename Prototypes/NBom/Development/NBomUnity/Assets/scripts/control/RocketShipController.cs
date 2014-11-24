using System.Collections;
using UnityEngine;
using GameUtil2D;

public class RocketShipController : MonoBehaviour
{
		private RocketShip rocketShip;
		private Thruster thruster;
		private ChargeThruster chargeThruster;
		private Teleport teleport;
		public KeyCode saveTeleportLocationKey = KeyCode.A;
		public KeyCode useTeleportAbilityKey = KeyCode.S;
		public KeyCode activateThrustAbilityKey = KeyCode.Space;
		public Ability abilitySelected = Ability.Boost;

		void Start ()
		{
				rocketShip = gameObject.GetComponent<RocketShip> ();
				thruster = gameObject.GetComponent<Thruster> ();
				chargeThruster = gameObject.GetComponent<ChargeThruster> ();
				teleport = gameObject.GetComponent<Teleport> ();
		}
	
		void FixedUpdate ()
		{		
				rocketShip = gameObject.GetComponent<RocketShip> ();
				thruster = rocketShip.GetComponent<Thruster> ();
				chargeThruster = rocketShip.GetComponent<ChargeThruster> ();
		
				if (abilitySelected == Ability.Boost) {
						if (FireBoostThrusterEvent) {
								MouseUtil2D.FaceMouse (rocketShip.gameObject);
								thruster.Boost ();
						}
				}

				if (abilitySelected == Ability.Thrust) {
						if (FireChargeBurstThrusterEvent) {
								MouseUtil2D.FaceMouse (rocketShip.gameObject);						
								chargeThruster.Charge ();
						}
			
						if (FireReleaseBurstThrustEvent) {
								chargeThruster.Release ();
								abilitySelected = Ability.Boost;
						}	
				}	
		

				if (Input.GetKeyDown (saveTeleportLocationKey)) {
						teleport.SavePosition ();
				}

				if (Input.GetKeyDown (useTeleportAbilityKey)) {
						teleport.Activate ();
				}

				if (chargeThruster) {
						if (Input.GetKeyDown (activateThrustAbilityKey)) {
								abilitySelected = Ability.Thrust;
						}
				}
		}

		bool FireBoostThrusterEvent {
				get {
						return Input.GetMouseButton (0);
				}
		}

		bool FireChargeBurstThrusterEvent {
				get {
						return Input.GetMouseButton (0);
				}
		}

		bool FireReleaseBurstThrustEvent {
				get {
						return FireChargeBurstThrusterEvent == false && chargeThruster.GetCharge > 0; 
				}
		}
}
