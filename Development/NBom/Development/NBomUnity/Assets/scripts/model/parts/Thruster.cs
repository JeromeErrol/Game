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
		gameObject.GetComponent<HeartRate> ().Tire();
		ParticleEmitter2D emmiter = GetComponent<ParticleEmitter2D> ();
		float radions = GOUtil2D.GetRadions(gameObject) - MathUtil2D.HALF_PI;
		if (emmiter) {
			emmiter.Shoot(radions);
		}
	}

	private FuelTank fuelTank{
		get{
			return gameObject.GetComponent<FuelTank>();
		}
	}
}
