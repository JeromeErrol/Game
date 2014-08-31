using UnityEngine;
using System.Collections;
using GameUtil2D;

public class RocketShip : MonoBehaviour
{
		public float boostSpeed;
		public float burstCharge;
		public float burstChargeSpeed = 10f;
		public float fuelCapacity = 1000f;
		public float fuelRemaining;

		void Start ()
		{
				fuelRemaining = fuelCapacity;
		}

		void Update ()
		{				
				
		}

		void OnTriggerEnter2D (Collider2D col)
		{
				
		}

		public bool BurstCharged {
				get {
						return burstCharge > 0;
				}
		}

		public void ChargeBurstThruster ()
		{
				if (FuelIsRemaining) {
						burstCharge += burstChargeSpeed;
						BurnFuel ();
				}
		}

		public bool FuelIsRemaining {
				get {
						return fuelRemaining > 0;
				}
		}

		public void BurnFuel ()
		{
				fuelRemaining -= 1;
				
				if (FuelIsRemaining) {
						print ("Fuel Remaining:" + fuelRemaining);
				} else {
						print ("Game Over!");
				}
		}

		public void ReleaseBurstThruster ()
		{
				Boost (burstCharge);
				burstCharge = 0;
		}

		public void BoostThruster ()
		{
				if (FuelIsRemaining) {
						Boost (boostSpeed);
						BurnFuel ();
				}				
		}

		private void Boost (float amount)
		{		
				gameObject.rigidbody2D.AddForce (this.transform.rotation * Vector3.up * amount);
		}
}
