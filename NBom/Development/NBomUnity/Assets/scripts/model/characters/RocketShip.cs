using UnityEngine;
using System.Collections;
using GameUtil2D;

public class RocketShip : MonoBehaviour
{
		public float boostSpeed;
		public float burstChargeSpeed = 10f;
		public FuelTank fuelTank;
		public float startingCapacity;
		public float startingFuel;
		private float burstCharge;
		public int points;
	
		void Start ()
		{
				fuelTank = new FuelTank (startingCapacity, startingFuel);
		points = 0;
				
		}

		void Update ()
		{				
				
		}

		void OnTriggerEnter2D (Collider2D col)
		{		
				GameObject gameObject = col.gameObject;
				print ("collision occured with: " + gameObject.name);	
				ICollideable collideable = gameObject.GetComponent<ICollideable> ();
				if (collideable) {
						collideable.CollidedWith (this);
				}
		}
	
		public bool BurstCharged {
				get {
						return burstCharge > 0;
				}
		}

		public void ChargeBurstThruster ()
		{
				if (fuelTank.FuelIsRemaining) {
						burstCharge += burstChargeSpeed;
						fuelTank.BurnFuel ();
				}
		}

		public void ReleaseBurstThruster ()
		{
				Boost (burstCharge);
				burstCharge = 0;
		}

		public void BoostThruster ()
		{
				if (fuelTank.FuelIsRemaining) {
						Boost (boostSpeed);
						fuelTank.BurnFuel ();
				}				
		}

		private void Boost (float amount)
		{		
				PhysicsUtil2D.ApplyForwardForce (gameObject.rigidbody2D, amount);
		}
}
