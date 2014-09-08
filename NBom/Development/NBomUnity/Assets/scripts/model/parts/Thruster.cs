using UnityEngine;
using System.Collections;
using GameUtil2D;

public class Thruster : MonoBehaviour {

	public float power;

	public void Boost(){
		if (fuelTank.FuelIsRemaining) {
			fuelTank.BurnFuel();
			PhysicsUtil2D.ApplyForwardForce (gameObject.rigidbody2D, power);
		}
	}

	private FuelTank fuelTank{
		get{
			return gameObject.GetComponent<FuelTank>();
		}
	}
}
