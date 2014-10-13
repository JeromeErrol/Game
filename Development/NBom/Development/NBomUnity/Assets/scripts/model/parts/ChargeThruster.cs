using System;
using UnityEngine;
using GameUtil2D;

public class ChargeThruster: MonoBehaviour
{
	private float charge;
	public int level;

	void Start(){
		if(level <= 0){
			level = 1;
		}
	}

	public float maxCharge{
		get{
			switch(level){
			case 1:
				return 2000;
			case 2:
				return 4000;
			default:
				return 0;
			} 
		}
	}

	public float chargeSpeed{
		get{
			switch(level){
			case 1:
				return 50;
			case 2:
				return 100;
			default:
				return 0;
			} 
		}
	}

	public void Charge(){
		if (fuelTank.FuelIsRemaining && charge < maxCharge) {
			charge += chargeSpeed;
			fuelTank.BurnFuel ();
		}
	}

	public float PercentCharged{
		get{
			return charge / maxCharge;
		}
	}

	public void Release(){
		if (fuelTank.FuelIsRemaining) {
			PhysicsUtil2D.ApplyForwardForce (gameObject.rigidbody2D, charge);
			charge = 0;
			Shield shield = gameObject.GetComponent<Shield>();
			shield.strength = 50;
		}
	}

	private FuelTank fuelTank{
		get{
			return gameObject.GetComponent<FuelTank>();
		}
	}

	public float GetCharge{
		get{
			return charge;
		}
	}

}



